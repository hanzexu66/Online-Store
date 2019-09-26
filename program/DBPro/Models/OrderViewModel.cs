using DBPro.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBPro.Models
{
    public class OrderViewModel
    {
        public string orderID { get; set; }
        public string userID { get; set; }
        public int orderState { get; set; }
        public string ReceiveID { get; set; }
        public DateTime createTime { get; set; }
        public int visibility { get; set; }
        public string userName { get; set; }
        public string userGender { get; set; }
        public int userLevel { get; set; }
        public string userIconID { get; set; }
        public string receiptName { get; set; }
        public string province { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string street { get; set; }
        public string detailAdress { get; set; }
        public string receiptPhone { get; set; }
        
        //List<OrderItem> itemid;
        public List<SearchItem> LSItem;
        public Dictionary<string, List<SearchItem>> DSItem;
    }
}
