using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DBPro.Models;
using System.Diagnostics;
using System.IO;
using DBPro.Parser;
using DBPro.Database;
using DBPro.Entity;

namespace DBPro.Controllers
{
    public class LoginController : Controller
    {
        public static Dictionary<string, string> CookieTrace = new Dictionary<string, string>();
        public static string Layout_name = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string getIDFromCookie()
        {
            var tem = HttpContext.Request.Cookies.Keys.ToList();
            
            if (tem.Count() != 0 )
            {
                foreach(var cook in tem)
                {
                    if (CookieTrace.ContainsKey(cook))
                        return CookieTrace[cook];
                }
                
            }
            return null;
        }

        public IActionResult Login()
        {
            var tem = getIDFromCookie();
            if (tem!=null)
            {
                var obj= DataBaseAccess.getObject<Account>(new Account(tem));
                return Login(obj.userID, obj.password);
            }
            return View();
        }
        public IActionResult Registe()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email,string password)
        {
                Account a = DataBaseAccess.getObject<Account>(new Account(email));
                if (a.password==password)
                {
                    User ui = DataBaseAccess.getObject<User>(new User(a.userID));
                    var tem = HttpContext.Request.Cookies.Keys.ToList();
                    if (tem.Count() != 0 )
                    {//////////////////////////////
                    foreach(var cook in tem)
                    {
                        if(!CookieTrace.ContainsKey(cook))
                            CookieTrace[cook] = email;
                    }
                        
                }
                ViewData["nickname"] = ui.userName;
                    return Redirect("/Home/Index");
                }
                else
                {
                    ModelState.AddModelError("Error", "Login Failed!");
                    return View();
                }
            
        }
        [HttpPost]
        public IActionResult Registe(string name,string gender,string email,string password, string phone,string nickname)
        {
            User u = new User(email, name,nickname, gender, Entity.User.normal, 0,"system");
            Account a = new Account(email, password, DateTime.Now, DateTime.Now, "0.0.0.0");
            if (DataBaseAccess.insertObj(u) && DataBaseAccess.insertObj(a))
            {
                return Login(email, password);
            }
            else
            {
                ModelState.AddModelError("Error", "SignUp Failed!");
                return View();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Logout()
        {
            var tem = getIDFromCookie();
            List<string> lkey = new List<string>();
            foreach (var cook in CookieTrace)
            {
                if (cook.Value == tem)
                    lkey.Add(cook.Key);
                    
            }
            foreach(var s in lkey)
            {
                CookieTrace.Remove(s);
            }
            return Redirect("Login");
        }
        private string getID()
        {
            System.Guid guid = new Guid();
            guid = Guid.NewGuid();
            string str = guid.ToString();
            return str.Substring(0, 15);
        }
    }
}
