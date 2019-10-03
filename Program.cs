using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_rundläggande_modellering
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("a) Check info");
            Console.WriteLine("b) Evaluate");

            string input = Console.ReadLine();

            if (input == "a")
            {
                b.PrintInfo();
            }

            if (input == "b" )
            {
                Console.WriteLine(b.Evaluate());
            }

            Console.ReadLine();
        }
    }
}
