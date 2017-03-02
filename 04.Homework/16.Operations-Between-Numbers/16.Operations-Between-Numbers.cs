using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            string act = Console.ReadLine();
            if (act == "+")
            {
                var sum = num1 + num2;
                if (sum % 2 == 0)
                {
                    Console.WriteLine("{0} + {1} = {2} - even", num1, num2, sum);
                }
                else
                {
                    Console.WriteLine("{0} + {1} = {2} - odd", num1, num2, sum);
                }
            }
            else if (act == "-")
            {
                var diff = num1 - num2;
                if (diff % 2 == 0)
                {
                    Console.WriteLine("{0} - {1} = {2} - even", num1, num2, diff);
                }
                else
                {
                    Console.WriteLine("{0} - {1} = {2} - odd", num1, num2, diff); 
                }
            }
            else if (act == "*")
            {
                var result = num1 * num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} * {1} = {2} - even", num1, num2,result);
                }
                else
                {
                    Console.WriteLine("{0} * {1} = {2} - odd", num1, num2, result);
                }
            }
            else if (act == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", num1);
                }
                else
                {
                    var division = num1 / num2;
                    Console.WriteLine("{0} / {1} = {2:f2}", num1, num2, division);
                }
            }
            else if (act == "%")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", num1);
                }
                else
                {
                    var leftnum = num1 % num2;
                    Console.WriteLine("{0} % {1} = {2}", num1, num2, leftnum);
                }
            }
        }
    }
}
