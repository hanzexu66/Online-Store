using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DBPro.Controllers;
using DBPro.Logic;
using DBPro.Models;

namespace FrontEnd.Controllers
{
    public class ReportController : Controller
    {
        /// <summary>
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
        
        [HttpPost]
        public IActionResult Report(string i_id)
        {
            ReportViewModel model = new ReportViewModel();
            model.itemID = i_id;
            return View(model);
        }

        [HttpPost]
        public string addReport(string itemID,string reason)
        {
            string id = getID();
            if (id == null)
            {
                return itemID;
            }
            AccusationManager.itemAccusation(id, itemID, reason);
            return itemID;
        }
    }
}
