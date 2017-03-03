using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Division_without_leftover_PastPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num%2==0)
                {
                    p1++;
                }
                if (num%3==0)
                {
                    p2++;
                }
                if (num%4==0)
                {
                    p3++;
                }
            }
            Console.WriteLine("{0:0.00}%", (p1 / n) * 100);
            Console.WriteLine("{0:0.00}%", (p2 / n) * 100);
            Console.WriteLine("{0:0.00}%", (p3 / n) * 100);
        }
    }
}
