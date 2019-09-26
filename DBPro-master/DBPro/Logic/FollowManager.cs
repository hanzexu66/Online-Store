using DBPro.Database;
using DBPro.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBPro.Logic
{
    public class FollowManager
    {
        public static bool addFollow(string u_id,string s_id)
        {
            return DataBaseAccess.insertObj(new ShopFollow(u_id, s_id));
        }

        public static bool unFollow(string u_id,string s_id)
        {
            return DataBaseAccess.deleteObj(new ShopFollow(u_id, s_id));
        }
        public static List<Shop> getFollowShop(string u_id)
        {
            return DataBaseAccess.testQuery<Shop>($"select * from DBShop where DBShop.shopID in " +
                $"( select shopID from DBShopFollow where userID={u_id}");
        }
    }
}
