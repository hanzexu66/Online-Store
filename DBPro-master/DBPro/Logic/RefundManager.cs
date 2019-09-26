using DBPro.Database;
using DBPro.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBPro.Logic
{
    public class RefundManager
    {
        static int refundID = 0;
        static int getID()
        {
            return refundID++;
        }
        public static int createRefund(string o_id,string u_id, string reason)
        {
            int id = getID();
            if (DataBaseAccess.insertObj(new RefundInfo(id.ToString(),u_id, o_id, DateTime.Now, reason, 0)))
                return id;
            return -1;
        }
        public static List<RefundInfo> GetRefundInfo(string u_id)
        {
            return DataBaseAccess.testQuery<RefundInfo>($"select * from DBRefundInfo where userID={u_id}" +
                $"order by refundTime desc");
        }

    }
}
