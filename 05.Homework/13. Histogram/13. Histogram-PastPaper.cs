﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            double p0 = 0;
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num<200)
                {
                    p1++;
                }
                else if (200 <= num && num <= 399)
                {
                    p2++;  
                }
                else if (400<= num && num<=599)
                {
                    p3++;    
                }
                else if (600 <= num && num <= 799)
                {
                    p4++; 
                }
                else if (num>= 800)
                {
                    p5++;
                }  
            }
            Console.WriteLine("{0:0.00}%", (p1 / n) * 100);
            Console.WriteLine("{0:0.00}%", (p2 / n) * 100);
            Console.WriteLine("{0:0.00}%", (p3 / n) * 100);
            Console.WriteLine("{0:0.00}%", (p4 / n) * 100);
            Console.WriteLine("{0:0.00}%", (p5 / n) * 100);
        }
    }
}
