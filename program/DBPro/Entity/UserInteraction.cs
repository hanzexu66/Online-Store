using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBPro.Database;
namespace DBPro.Entity
{
    [DBTable("DBUserInteraction")]
    public class UserInteraction
    {
        public UserInteraction(string s_ID,string r_ID,DateTime time,string content=null)
        {
            senderID = s_ID;
            receiverID = r_ID;
            massageContent = content;
            massageTime = time;
        }
        public UserInteraction() { }
        [DBPrimaryKey("senderID")]
        [DBMember("senderID")]
        string senderID { get; set; }
        [DBPrimaryKey("receiverID")]
        [DBMember("receiverID")]
        string receiverID { get; set; }
        [DBMember("messageContent")]
        string massageContent { get; set; }
        [DBPrimaryKey("messageTime")]
        [DBMember("messageTime")]
        DateTime massageTime { get; set; }
    }
}
