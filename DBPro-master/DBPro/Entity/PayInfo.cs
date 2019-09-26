using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBPro.Database;
namespace DBPro.Entity
{
    [DBTable("DBPayInfo")]
    public class PayInfo
    {
        public PayInfo(string o_id,DateTime? time=null,double money=0)
        {
            orderID = o_id;
            payTime = time??DateTime.Now;
            payMoney = money;
        }
        public PayInfo() { }
        [DBPrimaryKey("orderID")]
        [DBMember("orderID")]
        string orderID { get; set; }
        [DBMember("payTime")]
        DateTime payTime { get; set; }
        [DBMember("payMoney")]
        double payMoney { get; set; }
    }
}
