using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Centimeters =");
            var centimeters = double.Parse(Console.ReadLine());
            var inches = centimeters/ 2.54;
            Console.Write("Inches=");
            Console.WriteLine(inches);
        }
    }
}
