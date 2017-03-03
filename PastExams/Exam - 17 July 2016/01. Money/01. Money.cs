using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcoins = double.Parse(Console.ReadLine());
            double chineseyuan = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());
            double bitcoinsLev = bitcoins * 1168;
            double chineseyuandollar = chineseyuan * 0.15;
            double chineseyuanLev = chineseyuandollar * 1.76;
            double result = (chineseyuanLev + bitcoinsLev) / 1.95;
            double resultwithoutCommission = result - (result * (commission/100));
            Console.WriteLine(resultwithoutCommission);
        }
    }
}
