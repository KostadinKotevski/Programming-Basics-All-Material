using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            if (budget<=100)
            {
                if (season =="summer")
                {
                    var spending = budget * 0.30;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:f2}", spending);
                }
                else if (season == "winter")
                {
                    var spending = budget * 0.70;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:f2}", spending);
                }
            }
            if (budget<=1000 && budget>100)
            {
                if (season == "summer")
                {
                    var spending = budget * 0.40;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:f2}", spending);
                }
                else if (season == "winter")
                {
                    var spending = budget * 0.80;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:f2}", spending);
                }
            }
            if (budget>1000)
            {
                if (season == "summer")
                {
                    var spending = budget * 0.90;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:f2}", spending);
                }
                else if (season == "winter")
                {
                    var spending = budget * 0.90;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:f2}", spending);
                }
            }
        }
    }
}
