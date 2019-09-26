using DBPro.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBPro.Entity
{
    [DBTable("DBUserInfo")]
    public class UserInformation
    {
        public enum userInfoVisibility { no,yes};
        public UserInformation(string rid,string id=null, string name = null, string pro = null, string c = null, string dis = null,
            string blo = null, string detail = null, string rec=null,int visible=1)
        {
            ReceiveID = rid;
            userID = id;
            receiptName = name;
            province = pro;
            city = c;
            district = dis;
            street = blo;
            detailAdress = detail;
            receiptPhone = rec;
            visibility = visible;
        }
        public UserInformation() { }

        [DBPrimaryKey("ReceiveID")]
        [DBMember("ReceiveID")]
        public string ReceiveID { get; set; }
        [DBMember("userID")]
        public string userID { get; set; }
        [DBMember("receiptName")]
        public string receiptName { get; set; }
        [DBMember("province")]
        public string province { get; set; }
        [DBMember("city")]
        public string city { get; set; }
        [DBMember("district")]
        public string district { get; set; }
        [DBMember("street")]
        public string street { get; set; }
        [DBMember("detailAdress")]
        public string detailAdress { get; set; }
        [DBMember("receiptPhone")]
        public string receiptPhone { get; set; }
        [DBMember("visibility")]
        public int visibility { get; set; }
    }
}
