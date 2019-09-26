using DBPro.Database;
using DBPro.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBPro.Logic
{
    public class AccusationManager
    {
        public static bool itemAccusation(string u_id,string i_id,string reason)
        {
            return DataBaseAccess.insertObj(new ItemAccusation(u_id, i_id, DateTime.Now, reason, 0));
        }

        public static bool shopAccusation(string u_id,string s_id,string reason)
        {
            return DataBaseAccess.insertObj(new ShopAccusation(u_id, s_id, DateTime.Now, reason, 0));
        }

        public static List<ItemAccusation> getItemAccusation(string u_id,string i_id)
        {
            return DataBaseAccess.testQuery<ItemAccusation>($"select * from DBItemAccusation where userID={u_id} AND itemID={i_id} " +
                $"order by accusationTime desc");
        }
        public static List<ItemAccusation> getItemAccusationByUID(string u_id)
        {
            return DataBaseAccess.testQuery<ItemAccusation>($"select * from DBItemAccusation where userID={u_id} " +
                $"order by accusationTime desc");
        }
        public static List<ItemAccusation> getItemAccusationByIID(string i_id)
        {
            return DataBaseAccess.testQuery<ItemAccusation>($"select * from DBItemAccusation where itemID={i_id} " +
                $"order by accusationTime desc");
        }
    }
}
