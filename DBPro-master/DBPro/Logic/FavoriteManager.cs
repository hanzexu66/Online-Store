using DBPro.Database;
using DBPro.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBPro.Logic
{
    public class FavoriteManager
    {
        public static bool addItem(string u_id, string i_id)
        {
            return DataBaseAccess.insertObj(new ItemCollection(u_id, i_id));
        }
        public static bool delItem(string u_id, string i_id)
        {
            return DataBaseAccess.deleteObj(new ItemCollection(u_id, i_id));
        }
        public static List<Item> getFavoriteItem(string u_id)
        {
            return DataBaseAccess.testQuery<Item>($"select * from DBItem where DBItem.itemID in " +
                $"( select itemID from DBItemCollection where userID={u_id}");
        }
    }
}
