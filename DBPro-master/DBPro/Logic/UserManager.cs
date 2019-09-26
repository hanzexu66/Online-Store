using DBPro.Database;
using DBPro.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBPro.Logic
{
    public class UserManager
    {
        public static bool updateInfo(string id, string name,string gender,string phone,string nickname)
        {
            return DataBaseAccess.ExecuteSql($"update DBuser set userName='{name}',userGender='{gender}',userNickName='{nickname}' where userID='{id}'") > 0;
        }

        public static bool updateIcon(string id,string imageID)
        {
            return DataBaseAccess.ExecuteSql($"update DBuser set userIconID='{imageID}' where userID='{id}'") > 0;
        }

        public static bool updatePassword(string id, string newpassword)
        {
            return DataBaseAccess.ExecuteSql($"update DBAccount set password='{newpassword}' where userID='{id}'") > 0;
        }

        public static bool changeLevel(string id)
        {
            return DataBaseAccess.ExecuteSql($"update DBUser set userLevel=1 where userID='{id}'") > 0;
        }

        public static int getLevel(string id)
        {
            List<User> users = DataBaseAccess.testQuery<User>($"select * from DBUser where userID='{id}'");
            return users[0].userLevel;
        }

        public static List<UserInformation> GetUserInformation(string id)
        {//获取一个用户的所有地址信息
            List<UserInformation> users = DataBaseAccess.testQuery<UserInformation>($"select * from DBUserInfo where userID='{id}'And visibility=1");
            return users;
        }
        public static bool addUserInfo(string id,string username,string province, string city, string district, string street, string detailaddress,  string phonenumber)
        {
            return DataBaseAccess.insertObj(new UserInformation(DateTime.Now.ToString(), id, username, province, city, district, street, detailaddress, phonenumber));
        }
        public static bool updateUserInfo(string rid, string province, string city, string district, string street, string detailaddress, string username, string phonenumber)
        {
            return DataBaseAccess.ExecuteSql($"update DBUserInfo set receiptName='{username}',province='{province}',city='{city}',district='{district}',street='{street}',detailAdress='{detailaddress}',receiptPhone='{phonenumber}'" +
                $"where ReceiveID='{rid}'") > 0;
        }
        public static bool deleteUserInfo(string rid)
        {
            return DataBaseAccess.ExecuteSql($"update DBUserInfo set visibility=0 where ReceiveID='{rid}'") > 0;
        }
        public static bool addMoney(string id,double money)
        {
            return DataBaseAccess.ExecuteSql($"update DBUser set userMoney='{money}' where userID='{id}'") > 0;
        }
    }
}
