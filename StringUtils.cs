using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCSWinApplication
{
    class StringUtils
    {
        public static void RemoveRepets(ref string str, char separator)
        {
            string[] strArr = str.Split(separator);
            List<string> used = new List<string>();
            StringBuilder res = new StringBuilder();
            
            foreach(string strElement in strArr)
            {
                if (used.IndexOf(strElement) == -1 && strElement != "")
                {
                    used.Add(strElement);
                    res.Append(string.Format("{0}{1}", strElement, separator));
                }
            }

            str = res.ToString();
        }

        public static string[] RemoveRepetsArr(string str, char separator)
        {
            string[] strArr = str.Split(separator);
            List<string> used = new List<string>();
            string[] res;

            foreach (string strElement in strArr)
            {
                if (used.IndexOf(strElement) == -1 && strElement != "")
                {
                    used.Add(strElement);
                }
            }

            res = new string[used.Count];
            for (int i = 0; i < used.Count; i++)
                res[i] = used[i] + separator;

            return res;
        }
    }
}
