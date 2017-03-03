using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DailyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            double workdays = double.Parse(Console.ReadLine());
            double daySalary = double.Parse(Console.ReadLine());
            double dollarexchangerate = double.Parse(Console.ReadLine());
            double monthlySalary = workdays * daySalary;
            double yearlysalary = monthlySalary * 12 + monthlySalary * 2.5;
            double incomeaftertax = yearlysalary - (yearlysalary * 0.25);
            double incomeaftertaxinBGN = incomeaftertax * dollarexchangerate;
            double incomeperdayaftertaxinBGN = incomeaftertaxinBGN / 365;
            Console.WriteLine(Math.Round(incomeperdayaftertaxinBGN,2));
        }
    }
}
