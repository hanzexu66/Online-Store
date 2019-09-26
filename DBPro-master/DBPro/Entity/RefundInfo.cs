using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBPro.Database;
namespace DBPro.Entity
{
    [DBTable("DBRefundInfo")]
    public class RefundInfo
    {
        public RefundInfo(string r_id,string u_id=null,string o_id=null,DateTime? time=null,string reason=null,int state=0)
        {
            refundID = r_id;
            userID = u_id;
            orderID = o_id;
            refundTime = time??DateTime.Now;
            refundReason = reason;
            refundState = state;
        }
        public RefundInfo() { }
        [DBPrimaryKey("refundID")]
        [DBMember("refundID")]
        string refundID { get; set; }
        [DBMember("userID")]
        string userID { get; set; }
        [DBMember("orderID")]
        string orderID { get; set; }
        [DBMember("refundTime")]
        DateTime refundTime { get; set; }
        [DBMember("refundReason")]
        string refundReason { get; set; }
        [DBMember("refundState")]
        int refundState { get; set; }
    }
}
