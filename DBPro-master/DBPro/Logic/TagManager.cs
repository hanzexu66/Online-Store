using DBPro.Database;
using DBPro.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBPro.Logic
{
    public class TagManager
    {
        public static bool AddTagToItem(string id,string tag)
        {
            return DataBaseAccess.insertObj(new ItemTag(id, tag));
        }
        public static bool AddTagToShop(string id,string tag)
        {
            return DataBaseAccess.insertObj(new ShopTag(id, tag));
        }
        public static List<ItemTag> getItemTags(string id)
        {
            return DataBaseAccess.testQuery<ItemTag>($"select * from DBItemTag where DBItemTag.itemID={id}");
        }
        public static List<ShopTag> getShopTags(string id)
        {
            return DataBaseAccess.testQuery<ShopTag>($"select * from DBShopTag where DBShopTag.shopID={id}");
        }
    }
}
