using DBPro.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBPro.Models
{
    public class PayViewModel
    {
       public List<string> Li_id;
        public List<SearchItem> LItem;
        public List<int> Lamount;
        public List<UserInformation> LReceive;
    }
}
