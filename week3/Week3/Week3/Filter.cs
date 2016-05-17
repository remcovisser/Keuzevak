using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    public static class Filter
    {
        public static string Present(this int value)
        {
            float temp = value / 100.0f;
            return ("$" + temp + 0).Replace(".", ",");
        }

        public static float Value(this string value)
        {
            return float.Parse( value.Replace("$", ""));
        }
    }
}
