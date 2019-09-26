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
    public class ShopsController :Controller
    {
        ShopDetailsViewModel smodel=new ShopDetailsViewModel();
        [HttpPost]
        public IActionResult ShopDetails(string s_id)
        {
            smodel.shop = SearchManager.searchSShop("", -1, s_id)[0];
            smodel.shop.LSItem= SearchManager.searchSItem("", -1, null, s_id);
            ImageManager.saveImage(smodel.shop);
            return View(smodel);
        }
    }
}
