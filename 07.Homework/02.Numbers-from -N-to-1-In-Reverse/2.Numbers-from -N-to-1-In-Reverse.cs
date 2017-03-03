using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Numbers_from__N_to_1_In_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbers are:");
            for (int i = n; i >=1; i-=1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
