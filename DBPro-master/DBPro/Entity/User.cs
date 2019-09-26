using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBPro.Database;
namespace DBPro.Entity
{
    [DBTable("DBUser")]
    public class User
    {
        public const int privilege = 1;
        public const int normal = 0;

        public User(string id,string name = null,string nickname=null, string gender = null, int level =normal,double money=0, string icon = null)
        {
            userId = id;
            userName = name;
            userNickName = nickname;
            userGender = gender;
            userLevel = level;
            userMoney = money;
            userIconID = icon;
        }
        public User() { }
        [DBPrimaryKey("userID")]
        [DBMember("userID")]
        public string userId { get; set; }
        [DBMember("userName")]
        public string userName { get; set; }
        [DBMember("userNickName")]
        public string userNickName { get; set; }
        [DBMember("userGender")]
        public string userGender { get; set; }
        [DBMember("userLevel")]
        public int userLevel { get; set; }
        [DBMember("userMoney")]
        public double userMoney { get; set; }
        [DBMember("userIconID")]
        public string userIconID { get; set; }
    }

}
