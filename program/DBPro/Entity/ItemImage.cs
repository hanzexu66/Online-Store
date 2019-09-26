using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBPro.Database;
namespace DBPro.Entity
{
    [DBTable("DBItemImage")]
    public class ItemImage
    {
        public ItemImage(string image,string i_ID=null)
        {
            imageID = image;
            itemID = i_ID;
        }
        public ItemImage() { }
        [DBPrimaryKey("imageID")]
        [DBMember("imageID")]
        public string imageID { get; set; }
        [DBMember("itemID")]
        public string itemID { get; set; }

    }
}
