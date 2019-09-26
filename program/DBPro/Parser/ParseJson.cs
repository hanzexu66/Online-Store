﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DBPro.Parser
{
    public static class ParseJson
    {
        
        public static Dictionary<string,string> parseSimpleParam(string s)
        {
            Dictionary<string, string> res = new Dictionary<string, string>();
            JObject tem =(JObject)JsonConvert.DeserializeObject(s);
            foreach(var prop in tem.Properties())
            {
                var value = tem.GetValue(prop.Name);
                if (value != null)
                    res.Add(prop.Name, value.ToString());
            }

            return res;
        }
        public static Dictionary<string, string> parsePostPar(string s)
        {
            string[] ls = s.Split("&");
            int len = ls.Length;
            Dictionary<string, string> res = new Dictionary<string, string>();
            foreach( var tem in ls)
            {
                string[] t = tem.Split("=");
                res.Add(t[0],t[1]);
            }
            return res;
        }

        public static Dictionary<string, Dictionary<string, string>> parseRoutingParam()
        {
            Dictionary<string, Dictionary<string, string>> res = new Dictionary<string, Dictionary<string, string>>();
            return null;
        }
    }
}
