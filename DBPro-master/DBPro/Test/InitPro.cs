using DBPro.Database;
using DBPro.Entity;
using DBPro.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBPro.Test
{
    public class InitPro
    {
        private static string imageBasePath = "./pic";
        static Random ran = new Random(123);
        public static void init()
        {
            DataBaseAccess.insertObj(new Image("system", imageBasePath + "/init/system"));
            DataBaseAccess.insertObj(new Image("systemShop", imageBasePath + "/init/system"));
            DataBaseAccess.insertObj(new User("system@123", "system", "system", "m", User.privilege, 1000, "system"));
            DataBaseAccess.insertObj(new Account("system@123", "123456", DateTime.Now, DateTime.Now, "127.0.0.1"));
            DataBaseAccess.insertObj(new Shop("systemShop", "system@123", "system", "systemShop", "测试店铺", DateTime.Now, DateTime.Now, 4.5, 150.025, 461, 314));
            
            for (int i=16;(i+1)<30;i+=2)
            {
                string itemid = OrderManager.getID()+"1";
                string imageid1= OrderManager.getID()+"2";
                string imageid2 = OrderManager.getID() + "3";
                DataBaseAccess.insertObj(new Item(itemid, "systemShop", string.Format("book{0}", i), ran.Next(30, 100), Itemtype.book.ToString(),
                    string.Format("book{0} introduction", i), ran.Next(0, 3000), ran.Next(0, 5)));
                DataBaseAccess.insertObj(new Image(imageid1, imageBasePath + "/book/" + i.ToString() + ".jpg"));
                DataBaseAccess.insertObj(new Image(imageid2, imageBasePath + "/book/" + (i+1).ToString() + ".jpg"));
                DataBaseAccess.insertObj(new ItemImage(imageid1, itemid));
                DataBaseAccess.insertObj(new ItemImage(imageid2, itemid));
            }
            for (int i = 31; (i + 1) < 45; i += 2)
            {
                string itemid = OrderManager.getID() + "1";
                string imageid1 = OrderManager.getID() + "2";
                string imageid2 = OrderManager.getID() + "3";
                DataBaseAccess.insertObj(new Item(itemid, "systemShop", string.Format("car{0}", i), ran.Next(30, 100), Itemtype.car.ToString(),
                    string.Format("car{0} introduction", i), ran.Next(0, 3000), ran.Next(0, 5)));
                DataBaseAccess.insertObj(new Image(imageid1, imageBasePath + "/car/" + i.ToString() + ".jpg"));
                DataBaseAccess.insertObj(new Image(imageid2, imageBasePath + "/car/" + (i + 1).ToString() + ".jpg"));
                DataBaseAccess.insertObj(new ItemImage(imageid1, itemid));
                DataBaseAccess.insertObj(new ItemImage(imageid2, itemid));
            }
            for (int i = 46; (i + 1) < 60; i += 2)
            {
                string itemid = OrderManager.getID() + "1";
                string imageid1 = OrderManager.getID() + "2";
                string imageid2 = OrderManager.getID() + "3";
                DataBaseAccess.insertObj(new Item(itemid, "systemShop", string.Format("clothing{0}", i), ran.Next(30, 100), Itemtype.clothing.ToString(),
                    string.Format("clothing{0} introduction", i), ran.Next(0, 3000), ran.Next(0, 5)));
                DataBaseAccess.insertObj(new Image(imageid1, imageBasePath + "/clothing/" + i.ToString() + ".jpg"));
                DataBaseAccess.insertObj(new Image(imageid2, imageBasePath + "/clothing/" + (i + 1).ToString() + ".jpg"));
                DataBaseAccess.insertObj(new ItemImage(imageid1, itemid));
                DataBaseAccess.insertObj(new ItemImage(imageid2, itemid));
            }
            for (int i = 151; (i + 1) < 165; i += 2)
            {
                string itemid = OrderManager.getID() + "1";
                string imageid1 = OrderManager.getID() + "2";
                string imageid2 = OrderManager.getID() + "3";
                DataBaseAccess.insertObj(new Item(itemid, "systemShop", string.Format("computer{0}", i), ran.Next(30, 100), Itemtype.computer.ToString(),
                    string.Format("computer{0} introduction", i), ran.Next(0, 3000), ran.Next(0, 5)));
                DataBaseAccess.insertObj(new Image(imageid1, imageBasePath + "/computer/" + i.ToString() + ".jpg"));
                DataBaseAccess.insertObj(new Image(imageid2, imageBasePath + "/computer/" + (i + 1).ToString() + ".jpg"));
                DataBaseAccess.insertObj(new ItemImage(imageid1, itemid));
                DataBaseAccess.insertObj(new ItemImage(imageid2, itemid));
            }
            for (int i = 1; (i + 1) < 15; i += 2)
            {
                string itemid = OrderManager.getID() + "1";
                string imageid1 = OrderManager.getID() + "2";
                string imageid2 = OrderManager.getID() + "3";
                DataBaseAccess.insertObj(new Item(itemid, "systemShop", string.Format("electric{0}", i), ran.Next(30, 100), Itemtype.electric.ToString(),
                    string.Format("electric{0} introduction", i), ran.Next(0, 3000), ran.Next(0, 5)));
                DataBaseAccess.insertObj(new Image(imageid1, imageBasePath + "/electric/" + i.ToString() + ".jpg"));
                DataBaseAccess.insertObj(new Image(imageid2, imageBasePath + "/electric/" + (i + 1).ToString() + ".jpg"));
                DataBaseAccess.insertObj(new ItemImage(imageid1, itemid));
                DataBaseAccess.insertObj(new ItemImage(imageid2, itemid));
            }
            for (int i = 61; (i + 1) < 75; i += 2)
            {
                string itemid = OrderManager.getID() + "1";
                string imageid1 = OrderManager.getID() + "2";
                string imageid2 = OrderManager.getID() + "3";
                DataBaseAccess.insertObj(new Item(itemid, "systemShop", string.Format("food{0}", i), ran.Next(30, 100), Itemtype.food.ToString(),
                    string.Format("food{0} introduction", i), ran.Next(0, 3000), ran.Next(0, 5)));
                DataBaseAccess.insertObj(new Image(imageid1, imageBasePath + "/food/" + i.ToString() + ".jpg"));
                DataBaseAccess.insertObj(new Image(imageid2, imageBasePath + "/food/" + (i + 1).ToString() + ".jpg"));
                DataBaseAccess.insertObj(new ItemImage(imageid1, itemid));
                DataBaseAccess.insertObj(new ItemImage(imageid2, itemid));
            }
            for (int i = 76; (i + 1) < 90; i += 2)
            {
                string itemid = OrderManager.getID() + "1";
                string imageid1 = OrderManager.getID() + "2";
                string imageid2 = OrderManager.getID() + "3";
                DataBaseAccess.insertObj(new Item(itemid, "systemShop", string.Format("furniture{0}", i), ran.Next(30, 100), Itemtype.furniture.ToString(),
                    string.Format("furniture{0} introduction", i), ran.Next(0, 3000), ran.Next(0, 5)));
                DataBaseAccess.insertObj(new Image(imageid1, imageBasePath + "/furniture/" + i.ToString() + ".jpg"));
                DataBaseAccess.insertObj(new Image(imageid2, imageBasePath + "/furniture/" + (i + 1).ToString() + ".jpg"));
                DataBaseAccess.insertObj(new ItemImage(imageid1, itemid));
                DataBaseAccess.insertObj(new ItemImage(imageid2, itemid));
            }
            for (int i = 91; (i + 1) < 105; i += 2)
            {
                string itemid = OrderManager.getID() + "1";
                string imageid1 = OrderManager.getID() + "2";
                string imageid2 = OrderManager.getID() + "3";
                DataBaseAccess.insertObj(new Item(itemid, "systemShop", string.Format("makeup{0}", i), ran.Next(30, 100), Itemtype.makeup.ToString(),
                    string.Format("makeup{0} introduction", i), ran.Next(0, 3000), ran.Next(0, 5)));
                DataBaseAccess.insertObj(new Image(imageid1, imageBasePath + "/makeup/" + i.ToString() + ".jpg"));
                DataBaseAccess.insertObj(new Image(imageid2, imageBasePath + "/makeup/" + (i + 1).ToString() + ".jpg"));
                DataBaseAccess.insertObj(new ItemImage(imageid1, itemid));
                DataBaseAccess.insertObj(new ItemImage(imageid2, itemid));
            }
            for (int i = 106; (i + 1) < 120; i += 2)
            {
                string itemid = OrderManager.getID() + "1";
                string imageid1 = OrderManager.getID() + "2";
                string imageid2 = OrderManager.getID() + "3";
                DataBaseAccess.insertObj(new Item(itemid, "systemShop", string.Format("medicine{0}", i), ran.Next(30, 100), Itemtype.medicine.ToString(),
                    string.Format("medicine{0} introduction", i), ran.Next(0, 3000), ran.Next(0, 5)));
                DataBaseAccess.insertObj(new Image(imageid1, imageBasePath + "/medicine/" + i.ToString() + ".jpg"));
                DataBaseAccess.insertObj(new Image(imageid2, imageBasePath + "/medicine/" + (i + 1).ToString() + ".jpg"));
                DataBaseAccess.insertObj(new ItemImage(imageid1, itemid));
                DataBaseAccess.insertObj(new ItemImage(imageid2, itemid));
            }
            for (int i = 121; (i + 1) < 135; i += 2)
            {
                string itemid = OrderManager.getID() + "1";
                string imageid1 = OrderManager.getID() + "2";
                string imageid2 = OrderManager.getID() + "3";
                DataBaseAccess.insertObj(new Item(itemid, "systemShop", string.Format("shoes{0}", i), ran.Next(30, 100), Itemtype.shoes.ToString(),
                    string.Format("shoes{0} introduction", i), ran.Next(0, 3000), ran.Next(0, 5)));
                DataBaseAccess.insertObj(new Image(imageid1, imageBasePath + "/shoes/" + i.ToString() + ".jpg"));
                DataBaseAccess.insertObj(new Image(imageid2, imageBasePath + "/shoes/" + (i + 1).ToString() + ".jpg"));
                DataBaseAccess.insertObj(new ItemImage(imageid1, itemid));
                DataBaseAccess.insertObj(new ItemImage(imageid2, itemid));
            }
            for (int i = 136; (i + 1) < 150; i += 2)
            {
                string itemid = OrderManager.getID() + "1";
                string imageid1 = OrderManager.getID() + "2";
                string imageid2 = OrderManager.getID() + "3";
                DataBaseAccess.insertObj(new Item(itemid, "systemShop", string.Format("smartphone{0}", i), ran.Next(30, 100), Itemtype.smartphone.ToString(),
                    string.Format("smartphone{0} introduction", i), ran.Next(0, 3000), ran.Next(0, 5)));
                DataBaseAccess.insertObj(new Image(imageid1, imageBasePath + "/smartphone/" + i.ToString() + ".jpg"));
                DataBaseAccess.insertObj(new Image(imageid2, imageBasePath + "/smartphone/" + (i + 1).ToString() + ".jpg"));
                DataBaseAccess.insertObj(new ItemImage(imageid1, itemid));
                DataBaseAccess.insertObj(new ItemImage(imageid2, itemid));
            }
           
        }
    }
}
