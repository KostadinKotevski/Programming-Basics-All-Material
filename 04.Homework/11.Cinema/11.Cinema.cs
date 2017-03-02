using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            double price = -1.0;
            if (type == "premiere")
            {
                price = 12.00;
                Console.WriteLine("{0:f2}", ((r * c) * price));
            }
            else if (type == "normal")
            {
                price = 7.50;
                Console.WriteLine("{0:f2}", ((r * c) * price));
            }
            else if (type == "discount")
            {
                price = 5.00;
                Console.WriteLine("{0:f2}", ((r * c) * price));
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
