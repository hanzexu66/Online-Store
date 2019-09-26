using DBPro.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBPro.Models
{
    public class ItemDetailViewModel
    {
        public string itemID { get; set; }
        public string shopID { get; set; }
        public string itemType { get; set; }
        public string itemName { get; set; }
        public double itemPrice { get; set; }
        public string shopName { get; set; }
        public List<ImageDetail> image { get; set; }
        public string itemIntroduction { get; set; }
        public int storeNum { get; set; }
        public int itemFollow { get; set; }
        public int itemScore { get; set; }
        public List<ItemEvaluationDetail> itemComment;
    }
    public class ItemEvaluationDetail
    {
        public string userID { get; set; }
        public string userName { get; set; }
        public string imageID { get; set; }
        public string imagePath { get; set; }
        public string evaluationContent { get; set; }
        public DateTime evaluationTime { get; set; }
    }
    public class ImageDetail
    {
        public string imageID { get; set; }
        public string imagePath { get; set; }
        public byte[] img { get; set; }
    }
}
