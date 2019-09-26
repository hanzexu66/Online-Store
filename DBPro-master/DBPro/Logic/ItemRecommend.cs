using DBPro.Database;
using DBPro.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBPro.Logic
{
    public class ItemRecommend
    {
        public static List<Item> getItem(int num)
        {
            List<Item> res = DataBaseAccess.testQuery<Item>(
                $"select * from DBItem where ROWNUM <={num} ORDER BY LN(DBItem.itemFollow+1)*LN(100*itemScore+1) desc");
            return res;
        }
        public static List<Item> getItem(string type,int num)
        {
            List<Item> res = DataBaseAccess.testQuery<Item>(
                $"select * from DBItem where ROWNUM <={num} AND DBItem.itemType='{type}' ORDER BY LN(DBItem.itemFollow+1)*LN(100*itemScore+1) desc");
            return res;
        }
    }
}
