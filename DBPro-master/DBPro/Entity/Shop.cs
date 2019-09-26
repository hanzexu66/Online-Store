using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBPro.Database;
namespace DBPro.Entity
{
    [DBTable("DBShop")]
    public class Shop
    {
        public Shop(string s_ID,string u_ID=null,string name=null,string icon=null,string intro=null,
            DateTime? apply=null,DateTime? approval=null,double f_rate=0,double value=0,int s_vol=0,
            int f_vol=0)
        {
            shopID = s_ID;
            userID = u_ID;
            shopName = name;
            shopIcon = icon;
            shopIntroduction = intro;
            applicationTime = apply??DateTime.Now;
            approvalTime = approval??DateTime.Now;
            favorableRate = f_rate;
            salesValue = value;
            salesVolume = s_vol;
            followVolume = f_vol;
        }
        public Shop() { }
        [DBPrimaryKey("shopID")]
        [DBMember("shopId")]
        public string shopID { get; set; }
        [DBMember("userID")]
        public string userID { get; set; }
        [DBMember("shopName")]
        public string shopName { get; set; }
        [DBMember("shopIcon")]
        public string shopIcon { get; set; }
        [DBMember("shopIntroduction")]
        public string shopIntroduction { get; set; }
        [DBMember("applicationTime")]
        public DateTime applicationTime { get; set; }
        [DBMember("approvalTime")]
        public DateTime approvalTime { get; set; }
        [DBMember("favorableRate")]
        public double favorableRate { get; set; }
        [DBMember("salesValue")]
        public double salesValue { get; set; }
        [DBMember("salesVolume")]
        public int salesVolume { get; set; }
        [DBMember("followVolume")]
        public int followVolume { get; set; }
    }
}
