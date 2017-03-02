using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double sale = double.Parse(Console.ReadLine());
            double commission = -1.0;
            if (town == "sofia")
            {
                if (sale >= 0 && sale <= 500) { commission = 0.05; }
                else if (sale > 500 && sale <= 1000) { commission = 0.07; }
                else if (sale > 1000 && sale <= 10000) { commission = 0.08; }
                else if (sale > 10000) { commission = 0.12; }
                else { Console.WriteLine("error"); }
            }
            else if (town == "varna")
            {
                if (sale >= 0 && sale <= 500) { commission = 0.045; }
                else if (sale > 500 && sale <= 1000) { commission = 0.075; }
                else if (sale > 1000 && sale <= 10000) { commission = 0.10; }
                else if (sale > 10000) { commission = 0.13; }
                else { Console.WriteLine("error"); }
            }
            else if (town == "plovdiv")
            {
                if (sale >= 0 && sale <= 500) { commission = 0.055; }
                else if (sale > 500 && sale <= 1000) { commission = 0.08; }
                else if (sale > 1000 && sale <= 10000) { commission = 0.12; }
                else if (sale > 10000) { commission = 0.145; }
                else { Console.WriteLine("error"); }
            }
            else
            {
                Console.WriteLine("error");
            }   
            if (town == "sofia" || town == "varna"|| town == "plovdiv")
            {
                Console.WriteLine("{0:f2}", sale * commission);
            }
        }
    }
}
