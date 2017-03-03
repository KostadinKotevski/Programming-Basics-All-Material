using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sums_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int max = Math.Max(a, Math.Max(b, c));
            int min = Math.Min(a, Math.Min(b, c));
            int sum = a + b + c;
            var middle = sum - max - min;
            if (min + middle == max)
            {
                Console.WriteLine("{0}+{1}={2}",min,middle,max);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
