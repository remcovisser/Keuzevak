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
            Console.WriteLine(Count(ShowMeSomeFruits(fruits)));
            Console.ReadLine();
        }


        public static IEnumerable<Fruit> ShowMeSomeFruits(string[] fruits)
        {
            foreach (var item in fruits)
            {
                yield return new Fruit { Name = item }; 
            }
        }

        public static string Count(IEnumerable<Fruit> fruits)
        {
            int appleCount = 0;
            int peerCount = 0;
            foreach (var item in fruits)
            {
                if (item.Name == "apple")
                {
                    appleCount++;
                }
                else if (item.Name == "peer")
                {
                    peerCount++;
                }
            }
            return $"Aantal appels: {appleCount} en aantal peren:    {peerCount}";
        }
    }
}
