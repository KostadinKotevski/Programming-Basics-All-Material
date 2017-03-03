using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double magnolii = 3.25;
            double zombiuli = 4;
            double roze = 3.50;
            double cactus = 8;

            double numbermagnolii = double.Parse(Console.ReadLine());
            double numberzombiuli = double.Parse(Console.ReadLine());
            double numberrozi = double.Parse(Console.ReadLine());
            double numbercactus = double.Parse(Console.ReadLine());
            double priceofpresent = double.Parse(Console.ReadLine());

            double result = (magnolii * numbermagnolii) + (numberzombiuli * zombiuli) + (numberrozi * roze) + (numbercactus * cactus);
            double resultminustax = result - (result * 0.05);
            double enough = resultminustax - priceofpresent;
            if (resultminustax>=priceofpresent)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(enough));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(priceofpresent-resultminustax));
            }  
        }
    }
}
