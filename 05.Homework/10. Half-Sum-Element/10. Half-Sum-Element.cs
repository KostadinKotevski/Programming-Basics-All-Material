using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }
                sum = sum + num;
            }
            sum = sum - max;
            if (max == sum)
            {
                Console.WriteLine("Yes Sum =" + sum);
            }
            else
            {
                Console.WriteLine("No Diff =" + Math.Abs(sum - max));
            }
        }
    } 
    }
