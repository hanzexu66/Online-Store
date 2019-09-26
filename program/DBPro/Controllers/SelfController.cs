using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DBPro.Database;
using DBPro.Controllers;
using DBPro.Entity;
using DBPro.Models;
using DBPro.Logic;

namespace FrontEnd.Controllers
{
    public class SelfController : Controller
    {/// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
        private string getID()
        {
            var tem = HttpContext.Request.Cookies.Keys.ToList();

            if (tem.Count() != 0)
            {
                foreach (var cook in tem)
                {
                    if (LoginController.CookieTrace.ContainsKey(cook))
                        return LoginController.CookieTrace[cook];
                }

            }
            return null;
        }

        public IActionResult Self()
        {
            SelfViewModel model = new SelfViewModel();
            string id = getID();
            if (id == null)
            {
                return Redirect("/Login/Login");
            }
            User user = DataBaseAccess.getObject<User>(new User(id));
            model.nickName = user.userNickName;
            model.email = user.userId;
            model.balance = user.userMoney;
            model.name = user.userName;
            model.Icon = user.userIconID;
            model.IconPath=ImageManager.saveUserIcon(model.Icon);
            if (user.userGender == "m")
                model.gender = "male";
            else
                model.gender = "female";
            return View(model);
        }

        public IActionResult SelfChange()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SelfChange(string name,string gender,string phone,string nickname)
        {
            string id = getID();
            if (id == null)
            {
                return Redirect("/Login/Login");
            }
            if (gender == "male")
                UserManager.updateInfo(id, name, "m", phone, nickname);
            else
                UserManager.updateInfo(id, name, "f", phone, nickname);
            return Redirect("/Self/Self");
        }
        [HttpPost]
        public IActionResult addIcon(string UrlData)
        {
            byte[] bytes = Convert.FromBase64String(UrlData);
            string imageID = OrderManager.getID();
            ImageManager.addImage(imageID, bytes);
            string id = getID();
            if (id == null)
            {
                return Redirect("/Login/Login");
            }
            UserManager.updateIcon(id, imageID);
            return Redirect("/Self/Self");
        }

        public IActionResult Security()
        {
            SecurityViewModel model = new SecurityViewModel();
            string id = getID();
            if (id == null)
            {
                return Redirect("/Login/Login");
            }
            Account account = DataBaseAccess.getObject<Account>(new Account(id));
            model.password = account.password;
            return View(model);
        }

        public IActionResult Sendpassword(string newpassword, string oldpassword, string renewpassword)
        {
            string id = "";
            var tem = HttpContext.Request.Cookies.Keys.ToList();
            if (tem.Count() != 0 && LoginController.CookieTrace.ContainsKey(tem[0]))
            {//获取id
                id = LoginController.CookieTrace[tem[0]];
            }
            else//错误处理
            { return Redirect("Self/Security"); }
            Account account = DataBaseAccess.getObject<Account>(new Account(id));
            if (account.password == oldpassword)
            {
                UserManager.updatePassword(id, newpassword);
            }
            return Redirect("Self/Security");

        }

        public IActionResult Address()
        {
            AdressViewModel model = new AdressViewModel();
            string id = getID();
            if (id == null)
            {
                return Redirect("/Login/Login");
            }
            List<UserInformation> userInformation = UserManager.GetUserInformation(id);
            model.name = new List<string>();
            model.province = new List<string>();
            model.city = new List<string>();
            model.district = new List<string>();
            model.street = new List<string>();
            model.detailAdress = new List<string>();
            model.phone = new List<string>();
            model.rid = new List<string>();
            if (userInformation.Count() > 0)
            {
                for (int i = 0; i < userInformation.Count(); ++i)
                {
                    model.name.Add(userInformation[i].receiptName);
                    model.province.Add(userInformation[i].province);
                    model.city.Add(userInformation[i].city);
                    model.district.Add(userInformation[i].district);
                    model.street.Add(userInformation[i].street);
                    model.detailAdress.Add(userInformation[i].detailAdress);
                    model.phone.Add(userInformation[i].receiptPhone);
                    model.rid.Add(userInformation[i].ReceiveID);
                }
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Address(string province,string city,string district,string street,string detailaddress,string username,string phonenumber)
        {
            string id = getID();
            if (id == null)
            {
                return Redirect("/Login/Login");
            }
            UserManager.addUserInfo(id, username, province, city, district, street, detailaddress, phonenumber);
            return Address();
        }
        [HttpPost]
        public IActionResult Uaddress(string province, string city, string district, string street, string detailaddress, string username, string phonenumber,string rid)
        {
            string id = getID();
            if (id == null)
            {
                return Redirect("/Login/Login");
            }
            UserManager.updateUserInfo(rid,province, city, district, street, detailaddress,username, phonenumber);
            return Redirect("/Self/address");
        }

        public IActionResult Daddress(string rid)
        {
            string id = getID();
            if (id == null)
            {
                return Redirect("/Login/Login");
            }
            UserManager.deleteUserInfo(rid);
            return Redirect("/Self/address");
        }

        public IActionResult Charge()
        {
            return View();
        }
        [HttpPost]
        public int Charge(double money)
        {
            string id = getID();
            if (id == null)
            {
                return 0;
            }
            User user = DataBaseAccess.getObject<User>(new User(id));
            if (user.userMoney + Convert.ToDouble(money) > 99999999)
                return 2;
            else
            {
                UserManager.addMoney(id, user.userMoney + Convert.ToDouble(money));
                return 1;
            }
        }
    }

}