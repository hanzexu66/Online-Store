using DBPro.Database;
using DBPro.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBPro.Logic
{
    public class OrderManager
    {
        static int OrderID = 0;
        public static string createOrder(string u_id,string receive, List<string> LItemid, List<int> LAmount)
        {
            string ID = getID();
            if (DataBaseAccess.insertObj(new Order(ID, u_id, (int)Order.OrderStatus.undelivered, receive, DateTime.Now,(int)Order.orderVisibility.yes)))
            {
                for(int i=0;i< LItemid.Count();++i)
                {
                    DataBaseAccess.insertObj(new OrderItem(ID, LItemid[i],LAmount[i]));
                }
                return ID;
            }
                
            else return null;
        }
        /*
         * 7.12 0:50
         */
        public static string createOrderByShop(string u_id, string receive, List<string> LItemid, List<int> LAmount)
        {
            var DItem = SearchManager.searchItemByShop(LItemid);
            Dictionary<string, int> amount = new Dictionary<string, int>();
            for (int i = 0; i < LItemid.Count() && i < LAmount.Count(); ++i)
            {
                amount[LItemid[i]] = LAmount[i];
            }
            int count = 0;
            foreach (var pair in DItem)
            {
                ++count;
                string ID = getID();
                if (DataBaseAccess.insertObj(new Order(ID, u_id, 0, receive, DateTime.Now, (int)Order.orderVisibility.yes)))
                {
                    bool res = true;
                    double total = 0;
                    for (int i = 0; i < pair.Value.Count(); ++i)
                    {
                        res = res && DataBaseAccess.insertObj(new OrderItem(ID, pair.Value[i].itemID, amount[pair.Value[i].itemID]));
                        total += amount[pair.Value[i].itemID] * pair.Value[i].itemPrice;
                    }
                    if (!res)
                    {
                        --count;
                        int time = 3;
                        while (!DataBaseAccess.deleteObj(new Order(ID, u_id, 0, receive, DateTime.Now, (int)Order.orderVisibility.yes)) && time > 0) --time;
                        time = 3;
                        while (!addBalance(u_id, total) & time > 0) --time;
                    }
                }
            }
            if (count == DItem.Count())
                return "创建成功";
            else
                return $"部分订单创建失败，仅成功{count}个订单";
        }
        /*
         * 7.12 0:50
         */
        public static bool addBalance(string u_id, double num, bool add = true)
        {
            return DataBaseAccess.ExecuteSql($"update dbuser set userMoney=userMoney {(add == true ? $"+ {num} " : $"- {num} ")} " +
                $"where userid='{u_id}' ") > 0;
        }



        public static bool changeOrderState(string orderID, int state)
        {
            int time = 3;
            while (DataBaseAccess.ExecuteSql($"update dborder set orderState={state} where orderID='{orderID}' ")<= 0  && time > 0) --time;
            if (time == 0)
                return false;
            return true;
        }



        public static bool addOrderItem(string orderID,string itemID,double amount)
        {
            return DataBaseAccess.insertObj(new OrderItem(orderID, itemID, amount));
        }

        public static bool deleteOrder(string orderID)
        {
            return DataBaseAccess.ExecuteSql($"update dborder set visibility={(int)Order.orderVisibility.no} where orderID='{orderID}' ") > 0 ;
        }



        public static List<Order> GetOrder(string uID,int state)
        {
            return DataBaseAccess.testQuery<Order>($"select * from DBOrder where userID={uID} AND orderState={state} AND visibility=1");
        }
        public static List<Item> GetItemByOID(string o_id,List<OrderItem> lo)
        {
            if (lo != null)
                lo = DataBaseAccess.testQuery<OrderItem>($"select itemID from DBOrderItem where orderID={o_id}");

            return DataBaseAccess.testQuery<Item>($"select * from DBItem where itemID in " +
                $"( select itemID from DBOrderItem where orderID={o_id} )");
        }


        public static string getID()
        {
            return ((TimeSpan)(DateTime.Now - TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)))).TotalMilliseconds.ToString().Replace('.', '1');
        }
    }
}
