using Dapper;
using DBPro.Database;
using DBPro.Entity;
using DBPro.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBPro.Logic
{
    public class ImageManager
    {
        
        public static string getImage(string id,string type)
        {
            string path = Image.BasePath+ $"/{type}/{id}.jpg";
            if (File.Exists(path)) return  path;
            Image a = DataBaseAccess.getObject<Image>(new Image(id));
            File.WriteAllBytes(path, a.img);
            return  path;
        }
        /*public static string saveUserIcon(string id)
        {
            var res = getImage(id, "UserIcon");
            return $".." + res.Substring(9);
        }*/
        public static bool addImage(string id,byte[] img)
        {
            return (DataBaseAccess.insertObj(new Image(id, img)));
        }
        public static string getImagePath(Item i)
        {
             return $".."+Image.BasePath.Substring(9) + $"/{i.itemType}/{i.itemID}.jpg";
             
        }
        public static List<string> getImagePath(List<Item>li)
        {
            List<string> res = new List<string>();
           foreach(var s in li)
            {
                res.Add(getImagePath(s));
            }
            return res;
        }
        public static string getImagePath(Shop i)
        {
            return $".." + Image.BasePath.Substring(9) + $"/shop/{i.shopIcon}.jpg";

        }
        public static List<string> getImagePath(List<Shop> li)
        {
            List<string> res = new List<string>();
            foreach (var s in li)
            {
                res.Add(getImagePath(s));
            }
            return res;
        }

        public static void saveImage(List<SearchItem> ls)
        {
            if (ls == null || ls.Count == 0) return;
            var Args = new DynamicParameters();
            StringBuilder sql = new StringBuilder("select * from DBImage where imageID in (");
            Dictionary<string, Image> dtem = new Dictionary<string, Image>();
            int i = 0;
            foreach (var tem in ls)
            {
                tem.imagePath = Image.BasePath + $"/{tem.itemType}/{tem.imageID}.jpg";
                if (File.Exists(tem.imagePath)) { tem.imagePath = $".." + tem.imagePath.Substring(9); continue; }
                sql.Append($" :key{i} ,");
                Args.Add($"key{i}", tem.imageID);
                ++i;
            }
            
            if (i == 0) return;
            --sql.Length;
            sql.Append(" )");
            List<Image> lim = DataBaseAccess.Query<Image>(sql.ToString(), Args);
            foreach (var tem in lim)
            {
                dtem[tem.imageID] = tem;
            }
            foreach (var tem in ls)
            {
                if (!dtem.ContainsKey(tem.imageID)) continue;
                File.WriteAllBytes(tem.imagePath, dtem[tem.imageID].img);
                tem.imagePath = $".." + tem.imagePath.Substring(9);
            }
        }
        public static void saveImage(List<SearchShop> ls)
        {
            if (ls == null || ls.Count == 0) return;
            var Args = new DynamicParameters();
            StringBuilder sql = new StringBuilder("select * from DBImage where imageID in (");
            Dictionary<string, Image> dtem = new Dictionary<string, Image>();
            int i = 0;
            foreach (var tem in ls)
            {
                saveImage(tem.LSItem);

                tem.imagePath = Image.BasePath + $"/shop/{tem.imageID}.jpg";
                if (File.Exists(tem.imagePath)) { tem.imagePath = $".." + tem.imagePath.Substring(9); continue; }
                sql.Append($" :key{i} ,");
                Args.Add($"key{i}", tem.imageID);
                ++i;
            }
            if (i == 0) return;
            --sql.Length;
            sql.Append(" )");
            List<Image> lim = DataBaseAccess.Query<Image>(sql.ToString(), Args);
            foreach (var tem in lim)
            {
                dtem[tem.imageID] = tem;
            }
            foreach (var tem in ls)
            {
                if (!dtem.ContainsKey(tem.imageID)) continue;
                File.WriteAllBytes(tem.imagePath, dtem[tem.imageID].img);
                tem.imagePath = $".." + tem.imagePath.Substring(9);
            }
        }
        public static void saveImage(SearchShop ls)
        {
            var Args = new DynamicParameters();
            saveImage(ls.LSItem);
            ls.imagePath = Image.BasePath + $"/shop/{ls.imageID}.jpg";
            if (File.Exists(ls.imagePath)) { ls.imagePath = $".." + ls.imagePath.Substring(9); return; }
            Args.Add($"key", ls.imageID);
            List<Image> lim = DataBaseAccess.Query<Image>($"select * from DBImage where imageID=:key ", Args);
            File.WriteAllBytes(ls.imagePath, lim[0].img);
            ls.imagePath = $".." + ls.imagePath.Substring(9);
        }
        



        public static List<ImageDetail> getImageDetail(string i_id,string type)
        {
            List<ImageDetail> res = DataBaseAccess.testQuery<ImageDetail>($"select dbitemimage.imageid,null,img " +
                $"from dbitem natural join dbitemimage join dbimage on dbitemimage.imageid=dbimage.imageid where itemid='{i_id}' ");
            foreach (var i in res)
            {
                i.imagePath = Image.BasePath + $"/{type}/{i.imageID}.jpg";
                if (File.Exists(i.imagePath)) { i.imagePath =$".." + i.imagePath.Substring(9); continue; }
                File.WriteAllBytes(i.imagePath, i.img);
                i.imagePath = $".." + i.imagePath.Substring(9);
                i.img = null;
            }
            return res;
        }

        public static string saveUserIcon(string imageid)
        {
            string path= Image.BasePath + $"/UserIcon/{imageid}.jpg";
            saveImage(path, imageid);
            return strform(path);
        }
        public static string saveShopIcon(string imageid)
        {
            string path = Image.BasePath + $"/Shop/{imageid}.jpg";
            saveImage(path, imageid);
            return strform(path);
        }


        public static List<List<string>> saveItemImage(List<Item> li)
        {
            List<List<string>> res = new List<List<string>>();
            foreach (var item in li)
            {
                res.Add(saveItemImage(item));
            }
            return res;
        }

        public static List<string>saveItemImage(Item i)
        {
            List<Image> lim = DataBaseAccess.testQuery<Image>($"select * from dbimage where imageid in " +
                $"(select imageid from dbitem natural join dbitemimage where itemid='{i.itemID}') order by to_number(imageid) desc");
            List<string> res = new List<string>();
            string path = Image.BasePath + $"/{i.itemType}";
            foreach (var image in lim)
            {
                string tempath = path + $"/{image.imageID}.jpg";
                if (File.Exists(tempath)) { res.Add(strform(tempath));continue; }
                File.WriteAllBytes(tempath, image.img);
                res.Add(strform(tempath));
            }
            return res;
        }
        /*
            public static void saveImage(List<Item> li)
        {
            if (li == null || li.Count == 0) return;
            var Args = new DynamicParameters();
            //Args.Add("table", "");
            StringBuilder sql = new StringBuilder("select * from DBImage where imageID in (");
            int len = li.Count();
            for (int i = 0; i < len; ++i)
            {
                sql.Append($" :key{i} ,");
                Args.Add($"key{i}", li[i].itemID);
            }
            --sql.Length;
            sql.Append(")");
            List<Image> lim = DataBaseAccess.Query<Image>(sql.ToString(), Args);
            saveImage(lim, li);
        }
        
            public static void saveImage(List<Image>limgm, List<Item> li)
            {
                int len = li.Count();
                List<string> res = new List<string>();
                for(int i=0;i<len;++i)
                {
                    string path = Image.BasePath + $"/{li[i].itemType}/{li[i].itemID}.jpg";
                    if (File.Exists(path)) continue;
                    File.WriteAllBytes(path, limgm[i].img);
                }
            }
            */
        public static void saveImage(string path, string i_id)
        {
            if (File.Exists(path)) return;
            Image i = DataBaseAccess.getObject<Image>(new Image(i_id));
            File.WriteAllBytes(path, i.img);
        }
           static string strform(string s)
        {
            return @".." + s.Substring(9);
        }
        public static bool addImage(string id,string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            byte[] byteData = new byte[fs.Length];
            fs.Read(byteData, 0, byteData.Length);
            fs.Close();
            return addImage(id, byteData);
        }
    }
}
