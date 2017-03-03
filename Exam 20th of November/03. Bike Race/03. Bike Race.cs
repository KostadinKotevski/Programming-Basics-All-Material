using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            double juniours= double.Parse(Console.ReadLine());
            double seniors= double.Parse(Console.ReadLine());
            string tupeofrace = Console.ReadLine();
            if (tupeofrace == "trail")
            {
                double result = (juniours * 5.50) + (seniors*7);
                double resultminustax = result - (result*0.05);
                Console.WriteLine("{0:F2}", resultminustax);
            }
            else if (tupeofrace == "cross-country")
            {
                if (juniours+seniors>=50)
                {
                    double taxforjuniors = 8 - (8*0.25);
                    double taxforseniors = 9.50 - (9.50 * 0.25);
                    double result = (juniours * taxforjuniors) + (seniors * taxforseniors);
                    double resultminustax = result - (result * 0.05);
                    Console.WriteLine("{0:F2}", resultminustax);
                }
                else
                {
                    double result = (juniours * 8) + (seniors * 9.50);
                    double resultminustax = result - (result * 0.05);
                    Console.WriteLine("{0:F2}", resultminustax);
                } 
            }
            else if (tupeofrace == "downhill")
            {
                double result = (juniours * 12.25) + (seniors * 13.75);
                double resultminustax = result - (result * 0.05);
                Console.WriteLine("{0:F2}", resultminustax);
            }
            else if (tupeofrace == "road")
            {
                double result = (juniours * 20) + (seniors * 21.50);
                double resultminustax = result - (result * 0.05);
                Console.WriteLine("{0:F2}", resultminustax);
            }
        }
    }
}
