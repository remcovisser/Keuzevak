using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Part2
{
    public class Fruit
    {
        public string Name { get; set; }
      
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = {"apple", "peer", "orange", "banana", "apple", "peer", "orange", "banana"};
            foreach (var item in ShowMeSomeFruits(fruits))
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }


        public static IEnumerable<Fruit> ShowMeSomeFruits(string[] fruits)
        {
            foreach (var item in fruits)
            {
                if (item == "apple")
                {
                    yield return new Fruit { Name = "apple" };
                }
            }
        }
    }
}
