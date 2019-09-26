using Dapper;
using DBPro.Entity;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBPro.Database
{
    public enum returnType{rint,rbool,rvoid};
    public static class DataBaseAccess
    {
        static DBConnectionPool pool;
        static DataBaseAccess()
        {
            pool = DBConnectionPool.getInstance();
        }
        public static bool insertObj(object obj)
        {
            OracleConnection conn = pool.fetchConnection();
            bool res = OracleHelper.InsertObject(conn, obj);
            pool.releaseConnection(conn);
            return res;
        }
        public static bool updateObj(object obj)
        {
            OracleConnection conn = pool.fetchConnection();
            bool res = OracleHelper.Update(conn,obj);
            pool.releaseConnection(conn);
            return res;
        }
        public static bool deleteObj(object obj)
        {
            OracleConnection conn = pool.fetchConnection();
            bool res = OracleHelper.Delete(conn, obj);
            pool.releaseConnection(conn);
            return res;
        }
        public static bool existObj(object obj)
        {
            List<string> prikey = new List<string>(), prival = new List<string>();
            DBAttribute.getDBPrimaryElement(obj.GetType(), obj, prikey, prival);
            return exist(obj.GetType(), prikey, prival);
        }
        public static object RunProcedure(string storedProcName, OracleParameter[] parameters,returnType rt)
        {
            OracleConnection conn = pool.fetchConnection();
            object res=null;
            switch(rt)
            {
                case returnType.rvoid:OracleHelper.RunProcedure(conn, storedProcName, parameters);break ;
                case returnType.rint:res = OracleHelper.RunProcedureInt(conn, storedProcName, parameters); break ;
                case returnType.rbool:res=OracleHelper.RunProcedureBool(conn, storedProcName, parameters);break;
            }
            pool.releaseConnection(conn);
            return res;
        }


        public static bool exist(Type type,List<string> key, List<string> val)
        {
            OracleConnection conn = pool.fetchConnection();
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("select * from {0} where ", DBAttribute.getDBTable(type)));
            int len = key.Count();
            for (int i = 0; i < len; ++i)
            {
                if (i != 0)
                    sb.Append(" AND ");
                sb.Append($" {key[i]}={val[i]} ");

            }
            bool res = OracleHelper.Exists(conn, sb.ToString());
            pool.releaseConnection(conn);
            return res;
        }

        public static T getObject<T>(T Obj)
        {
            OracleConnection conn = pool.fetchConnection();
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("select * from {0} where ", DBAttribute.getDBTable(typeof(T))));
            List<string> key=new List<string>(), val=new List<string>();
            DBAttribute.getDBPrimaryElement(typeof(T), Obj, key, val);
            int len = key.Count();
            for(int i=0;i<len;++i)
            {
                sb.Append(string.Format(" {0}={1} AND ", key[i], val[i]));
            }
            sb.Length -= 4;
            List<T> lt = testQuery<T>(sb.ToString());  
            T res = lt.Count() == 0?Obj:lt[0];
            pool.releaseConnection(conn);
            return res;
        }
        public static OracleDataReader qerySql(string sqlStr)
        {
            return null;
        }
        public static List<T> testQuery<T>(string sqlStr)
        {
            OracleConnection conn = pool.fetchConnection();
            List<T> lt = SqlMapper.Query<T>(conn, sqlStr).ToList();
            pool.releaseConnection(conn);
            return lt;
        }
        public static List<T> Query<T>(string sql,DynamicParameters dp)
        {

            OracleConnection conn = pool.fetchConnection();
            List<T> lt = SqlMapper.Query<T>(conn, sql,dp).ToList();
            pool.releaseConnection(conn);
            return lt;
        }
        public static int ExecuteSql(string SQLString)
        {
            OracleConnection conn = pool.fetchConnection();
            int res = OracleHelper.ExecuteSql(conn, SQLString);
            pool.releaseConnection(conn);
            return res;
        }

    }
}
