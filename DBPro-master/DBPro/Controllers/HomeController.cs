using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DBPro.Models;
using DBPro.Database;
using DBPro.Parser;
using System.IO;
using DBPro.Entity;
using DBPro.Logic;

namespace DBPro.Controllers
{
    public class HomeController : Controller
    {
        public class userData
        {
            public string userNickName;
            public int userLevel;
            public int itemNumber;
        }
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
        public userData Indexx()
        {
            userData data = new userData();
            string id = getIDFromCookie();
            data.userLevel = UserManager.getLevel(id);
            data.userNickName = DataBaseAccess.getObject(new User(id)).userNickName;
            data.itemNumber = ItemManager.getItemNum(id);
            return data;
        }
        string strform(string s)
        {
            return @".." + s.Substring(9);
        }
        public IActionResult Index()
        {  
            HomeIndexViewModel model = new HomeIndexViewModel();
            model.CycleItem = SearchManager.searchSItem("", 5);
            model.CostumeItem = SearchManager.searchSItem("", 4, Itemtype.clothing.ToString());
            model.DailyItem= SearchManager.searchSItem("", 4, Itemtype.book.ToString());
            model.DigitItem = SearchManager.searchSItem("", 4, Itemtype.food.ToString());
            ImageManager.saveImage(model.CycleItem);
            ImageManager.saveImage(model.CostumeItem);
            ImageManager.saveImage(model.DailyItem);
            ImageManager.saveImage(model.DigitItem);
            /*model.CycleItem = ItemRecommend.getItem(5);
            model.CostumeItem= ItemRecommend.getItem(Itemtype.clothing.ToString(),4 );
            model.DailyItem= ItemRecommend.getItem(Itemtype.book.ToString(),4);
            model.DigitItem= ItemRecommend.getItem(Itemtype.food.ToString(),4);
            model.CycleItemImage = ImageManager.getImagePath(model.CycleItem);
            model.CostumeItemImage = ImageManager.getImagePath(model.CostumeItem); ;
            model.DailyItemImage = ImageManager.getImagePath(model.DailyItem); ;
            model.DigitItemImage = ImageManager.getImagePath(model.DigitItem); ;
            ImageManager.saveImage(new List<Item>().Union(model.CycleItem).Union(model.CostumeItem).Union(model.DigitItem).Union(model.DailyItem).ToList());
            */
            /*
                        for (int i=0;i<4;++i)
                        {
                            model.CycleItemImage.Add(strform(ImageManager.getImage(model.CycleItem[i].itemID,model.CycleItem[i].itemType)));
                            model.CostumeItemImage.Add(strform(ImageManager.getImage(model.CostumeItem[i].itemID, model.CostumeItem[i].itemType)));
                            model.DailyItemImage.Add(strform(ImageManager.getImage(model.DailyItem[i].itemID, model.DailyItem[i].itemType)));
                            model.DigitItemImage.Add(strform(ImageManager.getImage(model.DigitItem[i].itemID, model.DigitItem[i].itemType)));
                        }
                        model.CycleItemImage.Add(strform(ImageManager.getImage(model.CycleItem[4].itemID, model.CycleItem[4].itemType)));*/
            return View(model);
        }
        
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
