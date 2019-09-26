using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBPro.Entity
{
    public class SearchShop
    {
        public List<SearchItem> LSItem;
        public string shopID { get; set; }
        public string userID { get; set; }
        public string shopName { get; set; }
        public string userName { get; set; }
        public string shopIntroduction { get; set; }
        public double favorableRate { get; set; }
        public int salesVolume { get; set; }
        public int followVolume { get; set; }
        public int itemNum { get; set; }
        public string imageID { get; set; }
        public string imagePath { get; set; }
    }
}
