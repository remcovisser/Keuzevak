using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            AlistOfArguments("apple", "peert", "banana", "apple", "peer", "banana");
        }

        public static void AlistOfArguments(params string[] listOfFruits)
        {
            foreach (string fruit in listOfFruits)
            {
                Console.WriteLine(fruit);
            }
            
        }
    }
}
