using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBPro.Models
{
    public class RefundViewModel
    {
        public string refundID { get; set; }
        public string userID { get; set; }
        public string orderID { get; set; }
        public DateTime refundTime { get; set; }
        public string refundReason { get; set; }
        public int refundState { get; set; }
        public OrderViewModel order;
    }

}
