using DBPro.Database;
using DBPro.Entity;
using DBPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBPro.Logic
{
    public class SearchManager
    {

        public static List<SearchItem> searchSItem(string key, int num = -1, string type = null, string shopid = null, string shopname = null,string itemid=null)
        {
            if (num == 0) return null ;
            List<SearchItem> res = DataBaseAccess.testQuery<SearchItem>(
                $"select DBItem.itemID,DBItem.shopID,itemtype,itemname,itemprice,shopname,imageid,null,0,itemScore " +
                $" from DBItem join DBshop on DBitem.shopid = dbshop.shopid join " +
                $" (select ab.itemid, ab.imageid from DBItemImage ab where ab.imageid = " +
                $"(select imageid from DBItemImage bb where ab.itemid = bb.itemid AND rownum = 1) ) " +
                $" tem on tem.itemid = Dbitem.itemid " +
                $" where  DBItem.itemName LIKE '%{key}%' {(type==null?"": $" AND DBItem.itemtype='{type}' ")}" +
                $"{(shopid==null?"":$" AND DBItem.shopid='{shopid}' ")}" +
                $"{(shopname==null?"":$" AND DBItem.itemID in (select dbitem.itemID from dbitem join dbshop on dbitem.shopid=dbshop.shopid AND dbshop.shopname LIKE '%{shopname}%' )")} " +
                $" {(num == -1 ? "" : $" AND ROWNUM <= {num} ")} " +
                $" {(itemid == null ? "" : $" AND DBItem.itemID = '{itemid}' ")} " +
                $" ORDER BY LN(DBItem.itemFollow + 1) * LN(100 * itemScore + 1) desc");
            return res;
        }
        public static List<SearchShop> searchSShop(string key, int num = -1,string shopid=null)
        {
            if (num == 0) return null;
            List<SearchShop> res = DataBaseAccess.testQuery<SearchShop>($" with tem(tid,num) as "+
    $"    (select dbshop.shopid tid, count(dbitem.itemid) itemNum " +
    $"    from dbshop join dbitem on dbshop.shopid = dbitem.shopid " +
    $"    group by dbshop.shopid) " +
    $" select null, shopID, dbshop.userid, shopname, username, shopintroduction, " +
    $" favorablerate, salesvolume, followvolume, tem.num, shopIcon  imageID, null " +
    $" from DBShop join dbuser on dbshop.userid = dbuser.userid join tem on dbshop.shopid = tem.tid " +
    $" where shopname LIKE '%{key}%'  {(num == -1 ? "" : $" AND ROWNUM <= {num} ")}" +
    $"{(shopid==null?"":$" AND dbshop.shopid='{shopid}' ")}" +
    $" ORDER BY favorableRate * LN(salesValue + 1) * LN(followVolume + 1) * LN(salesVolume + 1) desc");
            return res;
        }

        public static List<OrderViewModel> searchOrder(string o_id = null, string u_id = null)
        {
            if (o_id == null && u_id == null) return null;
            List<OrderViewModel> res = DataBaseAccess.testQuery<OrderViewModel>($"select  dborder.orderid,dbuser.userid,orderstate," +
                $"DBUserInfo.receiveid,createtime,dborder.visibility,username,usergender,userlevel,userIconId,receiptname,province,city," +
                $"district,street,detailAdress,receiptphone,null,null  from dborder join dbuser on dborder.userid=dbuser.userid join  " +
                $"DBUserInfo on dborder.ReceiveID=DBUserInfo.ReceiveID  where {(u_id==null?"":$" dbuser.userid='{u_id}' ")}  " +
                $"{(o_id==null?"":u_id==null?$" dborder.orderid='{o_id}' ": $" AND dborder.orderid='{o_id}' ")} " +
                $" AND dborder.visibility={(int)Order.orderVisibility.yes}  ORDER BY createtime desc");
            foreach (var tem in res)
            {
                tem.LSItem = searchOrderItem(tem.orderID);
                ImageManager.saveImage(tem.LSItem);
                tem.DSItem = seperateByShop(tem.LSItem);
            }

            return res;
        }
        public static List<SearchItem> searchOrderItem(string o_id)
        {
            List<SearchItem> res = DataBaseAccess.testQuery<SearchItem>($"select DBItem.itemID,DBItem.shopID,itemtype,itemname," +
                $"DBItem.itemprice,shopname,imageid,null,itemamount  from DBItem join DBshop on DBitem.shopid = dbshop.shopid join  " +
                $"(select ab.itemid, ab.imageid from DBItemImage ab where ab.imageid =  " +
                $"(select imageid from DBItemImage bb where ab.itemid = bb.itemid AND rownum = 1) )  " +
                $"tem on tem.itemid = Dbitem.itemid join DBOrderItem on DBOrderItem.itemid=dbitem.itemid   where DBOrderItem.orderID = '{o_id}'");
            return res;
        }

        public static List<OrderViewModel> searchOrderByShop(string s_id=null,string o_id=null,int visible=(int)Order.orderVisibility.yes)
        {
            if (s_id == null && o_id == null) return null;
            List<OrderViewModel> res = DataBaseAccess.testQuery<OrderViewModel>($"select dborder.orderid,dbuser.userid,orderstate,DBUserInfo.receiveid,createtime,dborder.visibility," +
                $"username,usergender,userlevel,userIconId,receiptname,province,city,district,street,detailAdress,receiptphone,null,null from dborder join dbuser on " +
                $"dborder.userid=dbuser.userid join DBUserInfo on dborder.ReceiveID=DBUserInfo.ReceiveID where dborder.orderid in  (select distinct aa.orderid  from  " +
                $"dborder aa join dborderitem bb on aa.orderid=bb.orderid  join dbitem cc on bb.itemid=cc.itemid  {(s_id==null? " ) " : $"where cc.shopid='{s_id}' ) ")}" +
                $"{(o_id==null?"":$" AND dborder.orderid='{o_id}' ")} " +
                $"{(visible == (int)Order.orderVisibility.yes?$" AND dborder.visibility= {visible} ":"")} ORDER BY createtime desc");
            foreach (var tem in res)
            {
                tem.LSItem = searchOrderItem(tem.orderID);
                ImageManager.saveImage(tem.LSItem);
                tem.DSItem = seperateByShop(tem.LSItem);
            }
            return res;
        }

        public static Dictionary<string, List<SearchItem>> seperateByShop(List<SearchItem>lsi)
        {
            Dictionary<string, List<SearchItem>> res = new Dictionary<string, List<SearchItem>>();
            foreach(var it in lsi)
            {
                if (!res.ContainsKey(it.shopID)) res[it.shopID] = new List<SearchItem>();
                res[it.shopID].Add(it);
            }
            return res;
        }
            public static List<SearchItem> searchCItem(string u_id,int num=-1)
        {
            if (num == 0) return null;
            List<SearchItem> res = DataBaseAccess.testQuery<SearchItem>($"select " +
                $"DBItem.itemID,DBItem.shopID,itemtype,itemname,itemprice,shopname,imageid,null " +
                $" from DBItem join DBshop on DBitem.shopid = dbshop.shopid join " +
                $"(select ab.itemid, ab.imageid from DBItemImage ab where ab.imageid = " +
                $" (select imageid from DBItemImage bb where ab.itemid = bb.itemid AND rownum = 1) )  tem " +
                $"on tem.itemid = Dbitem.itemid  where DBItem.itemID in (select itemID from DBitemCollection where userid = '{u_id}' ) " +
                $"{(num==-1?"":$" AND ROWNUM <= {num} ")} ORDER BY LN(DBItem.itemFollow + 1) * LN(100 * itemScore + 1) desc" );
            return res;
        }
        public static List<SearchShop> searchCShop(string u_id,int num=-1)
        {
            if (num == 0) return null;
            List<SearchShop> res = DataBaseAccess.testQuery<SearchShop>($"with tem(tid,num) as " +
                $"(select dbshop.shopid tid,count(dbitem.itemid) num   from dbshop join dbitem on dbshop.shopid=dbitem.shopid   " +
                $"group by dbshop.shopid)  select " +
                $"null,shopID,dbshop.userid,shopname,username,shopintroduction,favorablerate,salesvolume,followvolume,tem.num," +
                $"shopIcon imageID,null  from DBShop join dbuser on  dbshop.userid=dbuser.userid join tem on dbshop.shopid=tem.tid  " +
                $"where shopid in (select   shopid from DBshopFollow where userid='121@q' ) {(num == -1 ? "" : $" AND ROWNUM <= {num} ")}   " +
                $"ORDER BY favorableRate*LN(salesValue+1)*LN(followVolume+1)*LN(salesVolume+1) desc");
            return res;
        }

        public static ItemDetailViewModel getItem(string i_id)
        {
            List<ItemDetailViewModel> res = DataBaseAccess.testQuery<ItemDetailViewModel>($"with tem(tid,num) as  " +
                $"(select dbitem.itemid, count(userid) from DBitemCollection right outer join dbitem on dbitem.itemid=DBitemCollection.itemid group by dbitem.itemid)   " +
                $"select  DBItem.itemID,DBItem.shopID,itemtype,itemname,itemprice,shopname,null,itemIntroduction,0,tem.num,itemScore,null  " +
                $"from DBItem join DBshop on DBitem.shopid = dbshop.shopid,tem   where DBItem.itemID= '{i_id}'  AND tem.tid=DBItem.itemID ");

            return res[0];
        }
            
        
        public static List<RefundViewModel> searchRefund(string u_id=null,string r_id=null)
        {
            if (u_id == null && r_id == null) return null;
            List<RefundViewModel> res=DataBaseAccess.testQuery<RefundViewModel>($"select refundid,userid,orderid,refundtime,refundreason," +
                $"refundstate,null from DBRefundInfo where {(u_id==null?"":$" userid='{u_id}' ")}  {(r_id==null?"":u_id==null?$" refundid='{r_id}' ":$" AND refundid='{r_id}' ")}");
            foreach(var tem in res)
            {
                tem.order = searchOrder(tem.orderID)[0];
            }
            return res;
        }


        public static List<UserInformation> searchReceive(string u_id)
        {
            List<UserInformation> res = DataBaseAccess.testQuery<UserInformation>($"select dbuserinfo.receiveid,dbuserinfo.userid," +
                $"dbuserinfo.receiptname,province,city,district,street,detailadress,receiptphone ,dbuserinfo.visibility " +
                $"from dbuserinfo where dbuserinfo.visibility={(int)UserInformation.userInfoVisibility.yes} AND userid='{u_id}'");

            return res;
        }

        /*
         * 7.12 0:50
         */
        public static Dictionary<string, List<Item>> searchItemByShop(List<string> itemid)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from dbitem where itemid in ( ");
            foreach (var id in itemid)
            {
                sb.Append($" '{id}',");
            }
            --sb.Length;
            sb.Append(" )");
            List<Item> Litem = DataBaseAccess.testQuery<Item>(sb.ToString());
            return separateItemByShop(Litem);
        }
      /*
       * 7.12 0:50
       */
        public static Dictionary<string, List<Item>> separateItemByShop(List<Item> Li)
        {
            Dictionary<string, List<Item>> res = new Dictionary<string, List<Item>>();
            foreach (var item in Li)
            {
                if (!res.ContainsKey(item.shopID))
                    res[item.shopID] = new List<Item>();
                res[item.shopID].Add(item);
            }
            return res;
        }
        /*
                    public static List<Item> searchByType(string type, string key, int num)
                    {
                        List<Item> res = DataBaseAccess.testQuery<Item>
                            ($"select * from DBItem where ROWNUM <={num} AND DBItem.itemType={type} AND DBItem.itemName LIKE '%{key}%'" +
                            $"ORDER BY LN(DBItem.itemFollow+1)*LN(100*itemScore+1) desc");
                        return res;
                    }
                    public static List<Item> search(string key, int num)
                    {
                        List<Item> res = DataBaseAccess.testQuery<Item>
                ($"select * from DBItem where ROWNUM <={num} AND DBItem.itemName LIKE '%{key}%'" +
                $"ORDER BY LN(DBItem.itemFollow+1)*LN(100*itemScore+1) desc");
                        return res;
                    }
                    public static List<Item> searchItemByShop(string key, int num)
                    {
                        List<Item> res= DataBaseAccess.testQuery<Item>
                ($"  select * from DBItem where ROWNUM <={num} AND  DBItem.itemID in " +
              $"(select itemID from dbshopItem join dbshop on dbshop.shopname = {key} )" +
              $"ORDER BY LN(DBItem.itemFollow+1)*LN(100*itemScore+1) desc ; ");
                        return res;
                    }
                    public static List<Item> searchShop(string sname,string key, int num)
                    {
                        List<Item> res = DataBaseAccess.testQuery<Item>
                ($"  select * from DBItem where ROWNUM <={num} AND  DBItem.itemID in " +
              $"(select itemID from dbshopItem join dbshop on dbshop.shopname = {sname} ) AND DBItem.itemName LIKE '%{key}%' " +
              $"ORDER BY LN(DBItem.itemFollow+1)*LN(100*itemScore+1) desc ");
                        return res;
                    }
                    public static List<Item> searchItemByShop(string id, string key, int num)
                    {
                        List<Item> res = DataBaseAccess.testQuery<Item>
                ($"  select * from DBItem where ROWNUM <={num} AND  DBItem.itemID in " +
              $"(select itemID from dbshopItem join dbshop on dbshop.shopID = {id} ) AND DBItem.itemName LIKE '%{key}%' " +
              $"ORDER BY LN(DBItem.itemFollow+1)*LN(100*itemScore+1) desc ");
                        return res;
                    }
                    public static List<Shop> searchShop(string sname, int num)
                    {
                        List<Shop> res = DataBaseAccess.testQuery<Shop>
            (
            $"select * from dbshop where ROWNUM <={num} AND dbshop.shopname LIKE '%{sname}%' " +
            $"ORDER BY favorableRate*LN(salesValue+1)*LN(followVolume+1)*LN(salesVolume+1) desc ");
                        return res;
                    }*/
    }
}
