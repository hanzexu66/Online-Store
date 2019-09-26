using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using DBPro.Entity;
using DBPro.Logic;
using DBPro.Models;
using Microsoft.AspNetCore.Mvc;

namespace DBPro.Controllers
{
    public class SearchController : Controller
    {
        public enum SearchSort {scoreDown,scoreUp,priceDown,priceUp}
        public IActionResult ItemSearch(string key,string type=null,int sortType=-1,int num=-1)
        {
            SearchViewModel cmodel = new SearchViewModel();
            if (key == null) key = "";
            cmodel.LSItem = SearchManager.searchSItem(key, num,type);
            ImageManager.saveImage(cmodel.LSItem);
            if(sortType!=-1)
            {
                
                switch (sortType)
                {
                    case (int)SearchSort.scoreDown:  cmodel.LSItem= cmodel.LSItem.OrderByDescending(s => s.itemScore).ToList(); break;
                    case (int)SearchSort.scoreUp: cmodel.LSItem = cmodel.LSItem.OrderBy(s => s.itemScore).ToList(); break;
                    case (int)SearchSort.priceDown: cmodel.LSItem = cmodel.LSItem.OrderByDescending(s => s.itemPrice).ToList(); break;
                    case (int)SearchSort.priceUp: cmodel.LSItem = cmodel.LSItem.OrderBy(s => s.itemPrice).ToList(); break;
                        
                }
            }
            return View(cmodel);
        }

        public IActionResult ShopSearch(string key)
        {
            SearchViewModel cmodel = new SearchViewModel();
            cmodel.LSShop = SearchManager.searchSShop(key, 10);
            foreach(var tem in cmodel.LSShop)
            {
                tem.LSItem = SearchManager.searchSItem("", 10, null, tem.shopID);
            }
            ImageManager.saveImage(cmodel.LSShop);
            return View(cmodel);
        }
        }
}