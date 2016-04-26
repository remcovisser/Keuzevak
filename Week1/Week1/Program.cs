using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User {Name = "remco", Id = 0908443};
            User user2 = new User {Name = "piet", Id = 00000};

            Console.WriteLine("Fill in a name");
            string name = Console.ReadLine();
            Console.WriteLine("Fill in a student number");
            int id = Int32.Parse(Console.ReadLine());
            User user3 =  new User {Name = name, Id = id};

            Console.WriteLine("Fill in a name");
            name = Console.ReadLine();
            Console.WriteLine("Fill in a student number");
            id = Int32.Parse(Console.ReadLine());
            User user4 = new User { Name = name, Id = id };


            UserAccount userAccount1 = new UserAccount("Remco", 0908443);
            UserAccount userAccount2 = new UserAccount("Piet", 000000);

        }
    }
}
