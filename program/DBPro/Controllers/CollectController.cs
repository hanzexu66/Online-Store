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
    public class CollectController : Controller
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

        CollectViewModel cmodel = new CollectViewModel();
        public IActionResult Collect()
        {
            string id = getIDFromCookie();
            if (id == null) return Redirect("/Login/Login");
            cmodel.LSItem = SearchManager.searchCItem(id);
            ImageManager.saveImage(cmodel.LSItem);
            return View(cmodel);
        }

        public IActionResult Shop()
        {
            string id = getIDFromCookie();
            if (id == null) return Redirect("/Login/Login");
            cmodel.LShop = SearchManager.searchCShop(id);
            foreach (var tem in cmodel.LShop)
            {
                tem.LSItem = SearchManager.searchSItem("", 3, null, tem.shopID);
            }
            ImageManager.saveImage(cmodel.LShop);
            return View(cmodel);
        }
        public string delectItemFromCollection(string i_id)
        {
            string u_id = getIDFromCookie();
            if (u_id == null) return "账号异常";
            int time = 3;
            while (!DataBaseAccess.deleteObj(new ItemCollection(u_id, i_id)) && time > 0) --time;
            if (time == 0) return "删除失败";
            return "删除成功";

        }
        public string delectShopFromCollection(string s_id)
        {
            string u_id = getIDFromCookie();
            if (u_id == null) return "账号异常";
            int time = 3;
            while (!DataBaseAccess.deleteObj(new ShopFollow(u_id, s_id)) && time > 0) --time;
            if (time == 0) return "删除失败";
            return "删除成功";

        }
        public string AddItemToCollection(string i_id)
        {
            string u_id = getIDFromCookie();
            if (u_id == null) return "账号异常";

            if (DataBaseAccess.existObj(new ItemCollection(u_id, i_id))) {  return "已收藏"; }
            int time = 3;
            while (!DataBaseAccess.insertObj(new ItemCollection(u_id, i_id)) && time > 0) --time;
            if (time == 0) return "收藏失败";

            return "收藏成功";
        }
        public string AddShopToCollection(string s_id)
        {
            string u_id = getIDFromCookie();
            if (u_id == null) return "账号异常";
            if (DataBaseAccess.existObj(new ShopFollow(u_id, s_id))) { return "已收藏"; }
            int time = 3;
            while (!DataBaseAccess.insertObj(new ShopFollow(u_id, s_id)) && time > 0) --time;
            if (time == 0) return "收藏失败";
            return "收藏成功";
        }
    }
}
