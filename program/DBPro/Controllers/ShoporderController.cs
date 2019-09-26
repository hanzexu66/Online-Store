using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DBPro.Models;
using System.Diagnostics;
using DBPro.Logic;

namespace DBPro.Controllers
{
    public class ShoporderController : Controller
    {
        [HttpPost]
        public IActionResult Shoporder(string s_id)
        {
            List<OrderViewModel> omodel = SearchManager.searchOrderByShop(s_id,null,-1);
            return View(omodel);
        }
        [HttpPost]
        public IActionResult Detail(string o_id)
        {
            OrderViewModel omodel = SearchManager.searchOrderByShop(null,o_id,-1)[0];
            return View(omodel);
        }
    }
}
