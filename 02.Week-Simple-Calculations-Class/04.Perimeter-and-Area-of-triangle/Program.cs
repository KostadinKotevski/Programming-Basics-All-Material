using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Perimeter_and_Area_of_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a");
            Console.WriteLine("Enter b");
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var area = (a * b) / 2;
            var perimeter = (a * 2) + b;
            Console.WriteLine("Area ="+area);
            Console.WriteLine("Perimeter="+perimeter);
        }
    }
}
