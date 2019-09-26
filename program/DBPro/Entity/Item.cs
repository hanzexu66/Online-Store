using DBPro.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBPro.Entity
{
    public enum Itemtype
    {
        electric, smartphone, computer, furniture, clothing,
        makeup, shoes, car,food,medicine,book,vproduct
    }
    [DBTable("DBItem")]
    public class Item
    {
        public Item(string i_id, string s_id=null, string name=null, double price=0,string type=null,
            string intro=null, int fol=0, double sco=0)
        {
            itemID = i_id;
            shopID = s_id;
            itemName = name;
            itemPrice = price;
            itemIntroduction = intro;
            itemFollow = fol;
            itemScore = sco;
            itemType = type;
        }
        public Item() { }
        [DBPrimaryKey("itemID")]
        [DBMember("itemID")]
        public string itemID { get; set; }
        [DBMember("shopID")]
        public string shopID { get; set; }
        [DBMember("itemName")]
        public string itemName { get; set; }
        [DBMember("itemPrice")]
        public double itemPrice { get; set; }
        [DBMember("itemIntroduction")]
        public string itemIntroduction { get; set; }
        [DBMember("itemFollow")]
        public int itemFollow { get; set; }
        [DBMember("itemScore")]
        public double itemScore { get; set; }
        [DBMember("itemType")]
        public string itemType { get; set; }
    }
}
