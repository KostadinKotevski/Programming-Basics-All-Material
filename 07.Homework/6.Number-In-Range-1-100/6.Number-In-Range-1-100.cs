﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Number_In_Range_1_100
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            while (n < 1 || n>100)
            {
                Console.WriteLine("Invalid Number!");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is : {0}",n);
        }
    }
}
