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
    public class CartController : Controller
    {
        private string getIDFromCookie()
        {
            var tem = HttpContext.Request.Cookies.Keys.ToList();
            if (tem.Count() != 0 && LoginController.CookieTrace.ContainsKey(tem[0]))
            {
                return LoginController.CookieTrace[tem[0]];
            }
            return null;
        }
        public IActionResult Cart()
        {
            string u_id = getIDFromCookie();
            if (u_id == null)
                return Redirect("/Login/Login");
            List<CartViewModels> cmodel = new List<CartViewModels>();
            
            cmodel = ShoppingCartManager.getModels(u_id);
            getImage(cmodel);
            return View(seperateModels(cmodel));
        }
        private List<List<CartViewModels>> seperateModels(List<CartViewModels> lc)
        {
            Dictionary<string, List<CartViewModels>> r = new Dictionary<string, List<CartViewModels>>();
            foreach(var mod in lc)
            {
                if (!r.ContainsKey(mod.shopID))
                    r[mod.shopID] = new List<CartViewModels>();
                r[mod.shopID].Add(mod);
            }
            List<List<CartViewModels>> res = new List<List<CartViewModels>>();
            foreach (var tem in r)
            {
                res.Add(tem.Value);
            }
            return res;
        }
        
        private void getImage(List<CartViewModels> lc)
        {
            foreach(var tem in lc)
            {
                tem.imagePath = $"./wwwroot/Image/{tem.itemType}/{tem.imageID}.jpg";
                ImageManager.saveImage(tem.imagePath,tem.imageID);
                tem.imagePath = ".."+tem.imagePath.Substring(9);
            }
        }
        public string AddItem(string i_id)
        {
            string u_id = getIDFromCookie();
            if (u_id == null)
                return "账号异常";
            if (DataBaseAccess.existObj(new ShoppingCart(u_id, i_id))) return "已存在购物车";
            int time = 3;
            //if (i_id == null) return null;
            while (!DataBaseAccess.insertObj(new ShoppingCart(u_id, i_id))&&time>0) --time;
            if (time == 0) return "加入购物车失败";
            return "加入购物车成功";
        }
        public string DeleteItem(string i_id)
        {
            string u_id = getIDFromCookie();
            if (u_id == null)
                return "账号异常";
            //if (i_id == null) return null;
            int time = 3;
            //if (i_id == null) return null;
            while (!DataBaseAccess.deleteObj(new ShoppingCart(u_id, i_id)) && time > 0) --time;
            if (time == 0) return "删除失败";
            
            return "删除成功";
        }
    }
}
