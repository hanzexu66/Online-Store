using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DBPro.Database;
using DBPro.Entity;
using DBPro.Controllers;
using DBPro.Models;

namespace FrontEnd.Controllers
{
    public class EvaluateController : Controller
    {
        //private string getIDFromCookie()
        //{
        //    var tem = HttpContext.Request.Cookies.Keys.ToList();
        //    if (tem.Count() != 0 && LoginController.CookieTrace.ContainsKey(tem[0]))
        //    {
        //        return LoginController.CookieTrace[tem[0]];
        //    }
        //    return null;
        //}


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
        public IActionResult Evaluate(string i_id)
        {
            EvaluateViewModel model = new EvaluateViewModel();
            model.itemID = i_id;
            model.item = DataBaseAccess.getObject<Item>(new Item(i_id));
            return View(model);
        }
        [HttpPost]
        public string EvaluateHandle(string i_id,string comment)
        {
            string u_id = getIDFromCookie();
            if(u_id==null)
            {
                return "账号异常";
            }
            int time = 3;
            while (!DataBaseAccess.insertObj(new ItemEvaluation(u_id, i_id, comment, DateTime.Now)) && time > 0) --time ;
            if (time == 0) return "评价失败";
            return "评价成功";
        }
    }
}
