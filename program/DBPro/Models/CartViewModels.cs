using DBPro.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBPro.Models
{
    public class CartViewModels
    {
        public string itemID { get; set; }     
        public string shopID { get; set; }
        public string itemType { get; set; }
        public string itemName { get; set; }
        public double itemPrice { get; set; }
        public string shopName { get; set; }
        public string imageID { get; set; }
        public string imagePath { get; set; }
        public int num { get; set; }

    }
}
