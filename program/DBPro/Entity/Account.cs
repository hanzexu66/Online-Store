using DBPro.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
namespace DBPro.Entity
{
    [DBTable("DBAccount")]
    public class Account
    {
        public Account(string ID , string pass = null, DateTime? register=null, DateTime? login=null, string ip = null)
        {
            
            this.userID = ID;
            this.password = pass;
            this.registerTime = register??DateTime.Now;
            this.lastLogin = login??DateTime.Now;
            this.lastLoginIP = ip;
        }
        public Account() { }

        
        //[DBMember("account")]
       // public string account { get; set; }

        [DBPrimaryKey("userID")]
        [DBMember("userID")]
        public string userID { get; set; }
        [DBMember("password")]
        public string password { get; set; }
        [DBMember("registerTime")]
        public DateTime registerTime { get; set; }
        [DBMember("lastLogin")]
        public DateTime lastLogin { get; set; }
        [DBMember("lastLoginIP")]
        public string lastLoginIP { get; set; }
    }
}
