﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Powers_of_two
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;
            for (var i = 0; i <= n; i++)
            {
                Console.WriteLine(num);
                num = num * 2;
            }
        }
    }
}