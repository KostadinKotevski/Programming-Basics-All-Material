using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            double X = double.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            double Z = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());
            double areaforwine = X * 0.4;
            double wineinliter = (areaforwine * Y) / 2.5;
            if (wineinliter>=  Z)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wineinliter));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wineinliter - Z), Math.Ceiling(Math.Ceiling(wineinliter - Z) / workers));   
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(Z - wineinliter));
            }
        }
    }
}
