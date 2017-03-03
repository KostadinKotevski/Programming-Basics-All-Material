using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double trips = 0;
            trips = Math.Ceiling(x / (w * m));
            Console.WriteLine(trips);
        }
    }
}
