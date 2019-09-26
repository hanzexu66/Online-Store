using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBPro.Entity
{
    public class SearchItem
    {
        public string itemID { get; set; }
        public string shopID { get; set; }
        public string itemType { get; set; }
        public string itemName { get; set; }
        public double itemPrice { get; set; }
        public string shopName { get; set; }
        public string imageID { get; set; }
        public string imagePath { get; set; }
        public double itemAmount { get; set; }
        public int itemScore;
    }
}
