using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBPro.Database;
namespace DBPro.Entity
{
    [DBTable("DBOrderItem")]
    public class OrderItem
    {
        public OrderItem(string o_id,string i_id,double amount=0)
        {
            orderID = o_id;
            itemID = i_id;
            itemAmount = amount;
        }
        public OrderItem() { }
        [DBPrimaryKey("orderID")]
        [DBMember("orderID")]
        string orderID { get; set; }
        [DBPrimaryKey("itemID")]
        [DBMember("itemID")]
        string itemID { get; set; }
        [DBMember("itemAmount")]
        double itemAmount { get; set; }
    }
}
