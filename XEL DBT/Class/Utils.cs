using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XEL_DBT
{
    public class Utils
    {

        public static void CfgSet(string key, string val)
        {

        }

        public static string CfgGet(string key)
        {

            return "";
        }

        public static string Clean(object obj)
        {
            if (obj == null) return "";
            var s = "";

            try
            {
                s = obj.ToString();
                s = s.Trim();
                return s;
            }
            catch
            {
                return "";
            }
        }



    }
}
