using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBPro.Models
{
    public class AdressViewModel
    {
        public string receiveID { get; set; }
        public List<string> name;
        public List<string> province;
        public List<string> city;
        public List<string> district;
        public List<string> street;
        public List<string> detailAdress;
        public List<string> phone;
        public List<string> rid;
    }
}
