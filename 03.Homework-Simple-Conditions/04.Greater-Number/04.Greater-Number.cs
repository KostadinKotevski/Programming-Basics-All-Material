﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            if (number1 > number2)
            {
                Console.WriteLine("Greater Number:"+number1);
            }
            else 
            {
                Console.WriteLine("Greater Number: "+number2);
            }
        }
    }
}
