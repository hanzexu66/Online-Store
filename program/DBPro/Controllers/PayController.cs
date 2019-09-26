using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DBPro.Models;
using System.Diagnostics;
using DBPro.Entity;
using DBPro.Logic;
using DBPro.Database;

namespace DBPro.Controllers
{
    public class PayController: Controller
    {
        /// <summary>
        /// /
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
        public IActionResult Pay(string i_ids, string amounts)
        {
            string u_id = getIDFromCookie();
            if (u_id == null)
                return Redirect("/Login/Login");
            PayViewModel model = new PayViewModel();
            model.Lamount = amounts.Split(',').ToList<string>().ConvertAll<int>(x => int.Parse(x));
            model.Li_id = i_ids.Split(',').ToList<string>();
            model.LItem = new List<SearchItem>();
            model.LReceive = new List<UserInformation>();
            foreach (var i in model.Li_id)
            {
                model.LItem.Add(SearchManager.searchSItem("", -1, null, null, null, i)[0]);
            }
            ImageManager.saveImage(model.LItem);
            model.LReceive = SearchManager.searchReceive(u_id);
            return View(model);
        }

        public string[] payment(string[] i_ids, string[] amounts, string receiveID, string total)
        {
            string[] sarr = new string[2];

            string u_id = getIDFromCookie();
            if (u_id == null) { sarr[0]="账号异常"; return sarr; }
            if (receiveID == null){ sarr[0]="请选择地址"; return sarr; }
            var user = DataBaseAccess.getObject<User>(new User(u_id));
            double totalPrice = double.Parse(total);
            if (user.userMoney <totalPrice) 
            { sarr[0]="余额不足"; return sarr; }
            //string o_id;
            sarr[0] = OrderManager.createOrderByShop(u_id, receiveID, i_ids.ToList(), amounts.ToList().ConvertAll<int>(x => int.Parse(x)));

            //if ((o_id = OrderManager.createOrder(u_id, receiveID, i_ids.ToList(), amounts.ToList().ConvertAll<int>(x=>int.Parse(x)))) == null)
            //{ sarr[0]="创建订单失败"; return sarr; }

            user.userMoney -= totalPrice;
            int time = 3;
            while (!DataBaseAccess.updateObj(user) && time > 3) --time;
            //{
            //    DataBaseAccess.deleteObj(new Order(o_id));
            //    { sarr[0]="创建订单异常"; return sarr; }
            //}
           //"创建成功";
            //sarr[1]=o_id;
            return sarr;
        }
    }
}
