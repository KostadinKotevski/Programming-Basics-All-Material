using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddsum = 0;
            var evensum = 0;
            for (int i = 0; i < n; i++)
            {
                var element = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    oddsum += element;
                }
                else
                {
                    evensum += element;
                } 
            }
            if (oddsum == evensum)
            {
                Console.WriteLine("Yes, sum = " + evensum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(oddsum - evensum));
            }
        }
    }
}
