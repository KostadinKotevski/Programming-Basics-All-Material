using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.House
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaofsmallestroom = double.Parse(Console.ReadLine());
            double areaofkitchen = double.Parse(Console.ReadLine());
            double priceofsquaremeter = double.Parse(Console.ReadLine());
            double bathroom = areaofsmallestroom / 2;
            double secondroom = areaofsmallestroom + (areaofsmallestroom * 0.10);
            double thrirdroom = secondroom + (secondroom * 0.10);
            double totalsquaremeters = areaofsmallestroom + bathroom + secondroom + thrirdroom+areaofkitchen;
            double totalsquaremeterscorr = totalsquaremeters + (totalsquaremeters * 0.05);
            double result = totalsquaremeterscorr * priceofsquaremeter;
            Console.WriteLine("{0:F2}", result);

        }
    }
}
