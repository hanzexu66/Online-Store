using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBPro.Database;
namespace DBPro.Entity
{
    [DBTable("DBOrder")]
    public class Order
    {
        public static Dictionary<int, string> OrderStateConvert = new Dictionary<int, string>{{0, "待发货"},{ 1, "待评价"},{2, "已完成" } };

        public enum OrderStatus
        {
            undelivered,
            unevaluated,
            finished
        }
        public enum orderVisibility { yes, no };
        public Order(string o_id,string u_id=null,int state=0, string receive=null,DateTime ?time=null,int visible=0)
        {
            orderID = o_id;
            userID = u_id;
            orderState = state;
            createTime = time??DateTime.Now;
            ReceiveID = receive;
            visibility = visible;
        }
        public Order() { }
        [DBPrimaryKey("orderID")]
        [DBMember("orderID")]
        string orderID { get; set; }
        [DBMember("userID")]
        string userID { get; set; }
        [DBMember("orderState")]
        int orderState { get; set; }
        [DBMember("ReceiveID")]
        string ReceiveID { get; set; }

        [DBMember("createTime")]
        DateTime createTime { get; set; }

        [DBMember("visibility")]
        int visibility { get; set; }
    }
}
