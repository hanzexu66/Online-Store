using DBPro.Database;
using DBPro.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBPro.Logic
{
    public class ShopManager
    {
        private static int shopID = 0;
        private static int getID()
        {
            return shopID++;
        }
        public static string createShop(string u_id,string shopName)
        {
            string ID = OrderManager.getID();
            if (DataBaseAccess.insertObj(new Shop(ID.ToString(), u_id, shopName, Image.defaultImageID, null, DateTime.Now, DateTime.Now, 0, 0, 0, 0)))
                return ID;
            else
                return null;
        }

        public static List<Shop> myShop(string u_id)
        {//根据用户id查找其店铺
            return DataBaseAccess.testQuery<Shop>($"select * from DBShop where userID='{u_id}'");
        }

        public static bool addTag(string s_id,string tag)
        {
            return DataBaseAccess.insertObj(new ShopTag(s_id, tag));
        }

        public static bool modifyName(string shopID,string shopName)
        {
            return DataBaseAccess.ExecuteSql($"update dbshop set shopName='{shopName}' where shopID='{shopID}'") > 0;
        }
        public static bool modifyIcon(string shopID, string shopIcon)
        {
            return DataBaseAccess.ExecuteSql($"update dbshop set shopIcon='{shopIcon}' where shopID='{shopID}'") > 0;
        }
        public static bool modifyIntro(string shopID, string shopIntro)
        {
            return DataBaseAccess.ExecuteSql($"update dbshop set shopIntroduction='{shopIntro}' where shopID='{shopID}'") > 0;
        }

        public static bool deleteShop(string shopID)
        {//Tag尚未删除
            return DataBaseAccess.deleteObj(new Shop(shopID, null, null, null, null, DateTime.Now, DateTime.Now, 0, 0, 0, 0));
        }

        public static bool addItem(string ItemID,string shopID,string ItemName,double price,string type,string ItemIntro)
        {
            return DataBaseAccess.insertObj(new Item(ItemID, shopID, ItemName, price, type, ItemIntro));
        }

        public static bool updateItem(string ItemID,string ItemName,double price,string ItemIntro)
        {
            return DataBaseAccess.ExecuteSql($"update dbitem set itemName='{ItemName}',itemPrice='{price}',itemIntroduction='{ItemIntro}'" +
                $"where itemID='{ItemID}'") > 0;
        }

        public static bool delItem(string ItemID)
        {
            List<ItemImage> list=DataBaseAccess.testQuery<ItemImage>($"select * from DBItemImage where itemID='{ItemID}'");
            if (!DataBaseAccess.deleteObj(new Item(ItemID)))
            {//删除itemimage表与item表
                return false;
            }
            for(int i=0;i<list.Count();++i)
            {
                if (!DataBaseAccess.deleteObj(new Image(list[i].imageID)))
                    return false;
            }
            return true;
        }

        public static List<Item> getItems(string s_id)
        {
            return DataBaseAccess.testQuery<Item>($"select * from DBItem where DBItem.shopID='{s_id}'");
        }

        public static List<Shop> searchShop(string shopName)
        {
            return DataBaseAccess.testQuery<Shop>($"select * from DBShop where DBShop.shopName='{shopName}'");
        }

        public static List<Shop> getDetail(string s_id)
        {
            return DataBaseAccess.testQuery<Shop>($"select * from DBShop where DBShop.shopID='{s_id}'");
        }

        public static Shop getShop(Item item)
        {
            return DataBaseAccess.testQuery<Shop>($"select * from DBShop where DBShop.shopID= '{item.shopID}'").ToArray()[0];
                
        }
        public static User getOwner(Shop shop)
        {
            return DataBaseAccess.testQuery<User>($"select * from DBUser where userID= '{shop.userID}' ").ToArray()[0];
        }
        public static List<User> getOwner(List<Shop> shop)
        {
            List<User> res = new List<User>();
            foreach(var tem in shop)
            {
                res.Add(getOwner(tem));
            }
            return res;
        }

        public static List<Shop> getShop(List<Item> li)
        {
            List<Shop> res = new List<Shop>();
            foreach(var tem in li)
            {
                res.Add(getShop(tem));
            }
            return res;
        }
    }
}
