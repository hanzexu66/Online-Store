using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DBPro.Models;
using System.Diagnostics;
using DBPro.Logic;
using DBPro.Database;
using DBPro.Entity;

namespace DBPro.Controllers
{
    public class GoodsController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string getIDFromCookie()
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
        [HttpPost]
        public IActionResult Details(string i_id)
        {
            ItemDetailViewModel imode = SearchManager.getItem(i_id);
            imode.image = ImageManager.getImageDetail(i_id, imode.itemType);
            imode.itemComment = CommentManager.getItemComment(i_id);
            imode.storeNum = new Random().Next(20, 1000);
            foreach (var tem in imode.itemComment)
            {
                tem.imagePath = ImageManager.saveUserIcon(tem.imageID);
            }
            return View(imode);
        }
        public ActionResult addFavorate(string i_id)
        {
            string u_id = getIDFromCookie();
            if (u_id == null) return Redirect("/Login/Login");
            if (!DataBaseAccess.insertObj(new ItemCollection(u_id, i_id)))
                HttpContext.Response.StatusCode = 400;
            return null;
        }
        public ActionResult addCart(string i_id)
        {
            string u_id = getIDFromCookie();
            if (u_id == null) return Redirect("/Login/Login");
            if (!DataBaseAccess.insertObj(new ShoppingCart(u_id, i_id)))
                HttpContext.Response.StatusCode = 400;
            return null;
        }
    }
}
