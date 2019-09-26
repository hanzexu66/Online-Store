using DBPro.Database;
using DBPro.Entity;
using DBPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBPro.Logic
{
    public class ShoppingCartManager
    {
        public static bool addItem(string u_id,string i_id)
        {
            return DataBaseAccess.insertObj(new ShoppingCart(u_id, i_id));
        }
        public static bool delItem(string u_id, string i_id)
        {
            return DataBaseAccess.deleteObj(new ShoppingCart(u_id, i_id));
        }
        public static List<Item> getItems(string u_id)
        {
            return DataBaseAccess.testQuery<Item>($"select * from DBItem where DBItem.itemID in "+
                $"(select itemID from DBShoppingCart where DBShoppingCart.userID={u_id})");
        }
        public static List<CartViewModels> getModels(string u_id)
        {
            List<CartViewModels> res = DataBaseAccess.testQuery<CartViewModels>($"  select "+

$" DBItem.itemID, DBItem.shopID, DBItem.itemType, DBItem.itemName, DBItem.itemPrice, shopName, imageid, null, 1 "+
$" from((DBShoppingCart join DBItem on DBShoppingCart.itemID = DBItem.itemID) join DBShop on DBItem.shopID = DBShop.shopID) join"+
 $" (select ab.itemid, ab.imageid from DBItemImage ab where ab.imageid = (select imageid from DBItemImage bb where ab.itemid = bb.itemid AND rownum = 1) ) "+
 $" tem on tem.itemid = DBItem.itemID "+
$" where DBShoppingCart.userID = '{u_id}'" );

            return res;
        }
    }
}
