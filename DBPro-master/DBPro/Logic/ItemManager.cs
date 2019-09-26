using DBPro.Database;
using DBPro.Entity;
using DBPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBPro.Logic
{
    public class ItemManager
    {
        public static bool addImage(string imageID,string itemID)
        {
            return DataBaseAccess.insertObj(new ItemImage(imageID, itemID));
        }

        public static int getItemNum(string u_id)
        {//根据用户id查找其购物车中商品数量
            List<ShoppingCart> cart = DataBaseAccess.testQuery<ShoppingCart>($"select * from DBshoppingcart where userid = '{u_id}' ");
            return cart.Count();
        }
    }
}
