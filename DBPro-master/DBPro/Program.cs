using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using DBPro.Database;
using Oracle.ManagedDataAccess.Client;
using DBPro.Entity;
using Microsoft.Extensions.Logging.Console.Internal;
using DBPro.Test;

namespace DBPro
{
    public class Program
    {
        
        static void readDT(DataTable dt)
        {
            foreach(DataColumn dc in dt.Columns)
            {
                System.Console.Write(dc + "\t");
            }
            System.Console.WriteLine();
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                System.Console.WriteLine(string.Join('\t', dt.Rows[i].ItemArray));
            }
        }
        static void readDS(DataSet ds)
        {
            for (int i = 0; i < ds.Tables.Count; ++i)
            {
                readDT(ds.Tables[i]);
            }
        }
        static void readByODR(OracleDataReader ord)
        {
            while(ord.Read())
            {
                System.Console.WriteLine(ord.GetInt32(0).ToString() + "\t"+ ord.GetOracleString(1) + "\t"+ord.GetOracleString(2) +"\t"+ord.GetInt32(3).ToString());
            }
            
        }
        public static void Main(string[] args)
        {
            //InitPro.init();
            CreateWebHostBuilder(args).Build().Run();
     

        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
