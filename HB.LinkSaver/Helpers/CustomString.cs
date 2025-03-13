using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB.LinkSaver.Helpers
{
    public static class CustomString
    {
        public static string GetCustomStringByLength(this string str, int count, bool dots = false)
                => str.Length > count ?
                    str.Substring(0, count) + (dots ? "..." : string.Empty)
                    : str;

    }

}
