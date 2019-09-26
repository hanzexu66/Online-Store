using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DBPro.Models;
using System.Diagnostics;
using DBPro.Entity;
using DBPro.Logic;

namespace DBPro.Controllers
{
    public class OrderController : Controller
    {

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

        public IActionResult Order(string o_id)
        {
            string u_id = getIDFromCookie();
            if (u_id == null) return Redirect("/Login/Login");
            List<OrderViewModel> omodel = SearchManager.searchOrder(o_id, u_id);
            return View(omodel);
        }

        public IActionResult OrderDetail(string o_id)
        {
            OrderViewModel omodel= SearchManager.searchOrder(o_id, null)[0];
            return View(omodel);
        }
        /*
        public string Refund(string o_id)
        {
            string u_id = getIDFromCookie();
            if (u_id == null) return "账号异常";
            bool res=changeOrderState(o_id,Entity.Order.OrderStatus.)
            return;
        }*/


        /*
         * 7.12 8:00
         */
        public string changeOrderState(string o_ID, int state)
        {
            bool res=OrderManager.changeOrderState(o_ID, state);
            if (!res) return "订单异常";
            return "修改成功";
        }


        public string deleteOrder(string o_id)
        {

            string u_id = getIDFromCookie();
            if (u_id == null) { return "账号异常"; }
            int time = 3;
            while (!OrderManager.deleteOrder(o_id) && time > 0) --time;
            if (time == 0) { return "删除失败"; }
            return "删除成功";
        }

        public IActionResult createOrder(string receiveID,List<string>LItemid,List<int>LAmount)
        {
            string u_id = getIDFromCookie();
            if (u_id == null) return Redirect("/Login/Login");
            OrderManager.createOrderByShop(u_id, receiveID, LItemid, LAmount);
            //OrderManager.createOrder(u_id, receiveID, LItemid, LAmount);
            return null;
        }
    }
}