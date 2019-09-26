using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DBPro.Logic;
using DBPro.Controllers;
using DBPro.Models;
using DBPro.Database;
using DBPro.Entity;

namespace FrontEnd.Controllers
{
    public class ShopController : Controller
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

        public IActionResult NewShop()
        {
            string id = getID();
            if (id == null)
            {
                return Redirect("/Login/Login");
            }
            NewShopViewModel model = new NewShopViewModel();
            User user = DataBaseAccess.getObject<User>(new User(id));
            model.name = user.userName;
            model.email = user.userId;
            return View(model);
        }
        [HttpPost]
        public IActionResult NewShop(string shopname,List<string> kinds)
        {
            string id = getID();
            if (id == null)
            {
                return Redirect("/Login/Login");
            }
            string shopID=ShopManager.createShop(id, shopname);//创建店铺
            UserManager.changeLevel(id);//修改等级

            for (int i=0;i<kinds.Count();++i)
            {
                ShopManager.addTag(shopID, kinds[i]);
            }
            return Redirect("/Home/Index");
        }
    }
}
