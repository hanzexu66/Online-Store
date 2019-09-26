using DBPro.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBPro.Models
{
    public class ShopInfoViewModel
    {
        public string shopID;
        public string name;
        public string intro;
        public string Icon;
        public List<Item> items;
        //public List<List<string>> itemImageID;
        public List<List<string>> itemImagePath;
        public string IconPath;
    }
}
