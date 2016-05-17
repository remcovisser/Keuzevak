using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            string value1 = "$41,30";
            int value2 = 4130;
            Console.WriteLine(value1.Value());
            Console.WriteLine(value2.Present());
            Console.ReadLine();
        }
    }
}
