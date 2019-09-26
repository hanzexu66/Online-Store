using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBPro.Database;
using DBPro.Entity;
using DBPro.Models;

namespace DBPro.Logic
{
    public class CommentManager
    {
        public static bool addComment(string u_id, string i_id, string content, DateTime time)
        {
            return DataBaseAccess.insertObj(new ItemEvaluation(u_id, i_id, content, DateTime.Now));
        }
        public static List<ItemEvaluation> getUserComment(string u_id)
        {
            return DataBaseAccess.testQuery<ItemEvaluation>($"select * from DBItemEvaluation where userID={u_id}" +
                $"order by evaluationTime desc");
        }
        public static List<ItemEvaluationDetail> getItemComment(string i_id)
        {
            return DataBaseAccess.testQuery<ItemEvaluationDetail>($"select DBItemEvaluation.userid,username,imageid,null,evaluationContent,evaluationTime  " +
                $"from  DBItemEvaluation join dbuser on DBItemEvaluation.userid=dbuser.userid " +
                $"join dbimage on dbuser.userIconID=dbimage.imageid where DBItemEvaluation.itemid='{i_id}' order by evaluationTime desc");
        }
    }
}
