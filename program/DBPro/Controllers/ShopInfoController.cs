using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DBPro.Controllers;
using DBPro.Models;
using DBPro.Logic;
using DBPro.Entity;
using DBPro.Database;

namespace FrontEnd.Controllers
{

    public class ShopInfoController : Controller
    {
        public class ShopInfo_ItemImage
        {
            public Item item;
            public string itemimage1;
            public string itemimage2;
            public string itemimage3;
            public string itemimage4;

        }
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
        
        public IActionResult ShopInfo()
        {
            ShopInfoViewModel model = new ShopInfoViewModel();
            string id = getID();
            if (id == null)
            {
                return Redirect("/Login/Login");
            }
            Shop myshop = ShopManager.myShop(id)[0];
            model.shopID = myshop.shopID;
            model.name = myshop.shopName;
            model.intro = myshop.shopIntroduction;
            model.items = ShopManager.getItems(myshop.shopID);
            model.Icon = myshop.shopIcon;
            model.IconPath=ImageManager.saveShopIcon(model.Icon);
            model.itemImagePath = ImageManager.saveItemImage(model.items);
            return View(model);
        }
        //店铺商品
        [HttpPost]
        public IActionResult AddItem(string itemID,string name,string pnumber,string type,string intro)
        {
            string id = getID();
            if (id == null)
            {
                return Redirect("/Login/Login");
            }
            Shop myshop = ShopManager.myShop(id)[0];
            ShopManager.addItem(itemID, myshop.shopID, name, System.Convert.ToDouble(pnumber), type, intro);
            return Redirect("/ShopInfo/ShopInfo");
        }
        [HttpPost]
        public IActionResult UpdateItem(string itemID,string name,string pnumber,string intro)
        {
            string id = getID();
            if (id == null)
            {
                return Redirect("/Login/Login");
            }
            Shop myshop = ShopManager.myShop(id)[0];
            ShopManager.updateItem(itemID, name, System.Convert.ToDouble(pnumber), intro);
            return Redirect("/ShopInfo/ShopInfo");
        }
        [HttpPost]
        public ShopInfo_ItemImage getItem(string itemID)
        {
            Item item= DataBaseAccess.getObject<Item>(new Item(itemID));
            ShopInfo_ItemImage shopInfo_ItemImage = new ShopInfo_ItemImage();
            shopInfo_ItemImage.item = item;
            var s = ImageManager.saveItemImage(item);
            for(int i= s.Count();i<4;++i)
            {
                s.Add("../Image/default/default.jpg");
            }
            shopInfo_ItemImage.itemimage1 = s[0];
            shopInfo_ItemImage.itemimage2 = s[1];
            shopInfo_ItemImage.itemimage3 = s[2];
            shopInfo_ItemImage.itemimage4 = s[3];
            return shopInfo_ItemImage;
        }
        [HttpPost]
        public bool deleteItem(string itemID)
        {
            return ShopManager.delItem(itemID);
        }
        [HttpPost]
        public bool updateImage(string[] UrlData,string itemID)
        {
            byte[] bytes;
            if (itemID == null)
                itemID = OrderManager.getID();
            for (int i=0;i<UrlData.Count();++i)
            {
                if(UrlData[i]!=null)
                {
                    bytes = Convert.FromBase64String(UrlData[i]);
                    string imageID = OrderManager.getID() + i;
                    ImageManager.addImage(imageID, bytes);//将图片加入数据库中
                    ItemManager.addImage(imageID, itemID);//添加图片与商品联系
                }
            }
            return true;
        }
        //店铺信息
        public IActionResult updateName(string name)
        {
            string id = getID();
            if (id == null)
            {
                return Redirect("/Login/Login");
            }
            if (name != null)
            {
                Shop myshop = ShopManager.myShop(id)[0];
                ShopManager.modifyName(myshop.shopID, name);
            }
            return Redirect("/ShopInfo/ShopInfo");
        }
        [HttpPost]
        public IActionResult updateIcon(string UrlData)
        {
            byte[] bytes = Convert.FromBase64String(UrlData);
            string imageID = OrderManager.getID(); ;
            ImageManager.addImage(imageID, bytes);
            string id = getID();
            if (id == null)
            {
                return Redirect("/Login/Login");
            }
            Shop myshop = ShopManager.myShop(id)[0];
            ShopManager.modifyIcon(myshop.shopID,imageID);
            return Redirect("/ShopInfo/ShopInfo");
        }
        public IActionResult updateIntro(string intro)
        {
            string id = getID();
            if (id == null)
            {
                return Redirect("/Login/Login");
            }
            Shop myshop = ShopManager.myShop(id)[0];
            ShopManager.modifyIntro(myshop.shopID, intro);
            return Redirect("/ShopInfo/ShopInfo");
        }
    }
}
