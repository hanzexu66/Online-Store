using DBPro.Database;
using DBPro.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBPro.Logic
{
    public class MessegeManager
    {
        public static bool send(string s_id,string r_id,string content,DateTime time)
        {
            //return DataBaseAccess.insertObj(new UserInteraction(s_id, r_id, content, time));
            return false;
        }
        public static List<UserInteraction>getMessageBySID(string s_id)
        {
            return DataBaseAccess.testQuery<UserInteraction>($"select * from DBUserInteraction where senderID={s_id}" +
                $"order by messageTime desc");
        }
        public static List<UserInteraction> getMessageByRID(string r_id)
        {
            return DataBaseAccess.testQuery<UserInteraction>($"select * from DBUserInteraction where receiverID={r_id}" +
                $"order by messageTime desc");
        }
    }
}
