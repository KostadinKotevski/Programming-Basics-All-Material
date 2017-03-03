using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double oddsum = 0;
            double evensum = 0;
            double oddmax = double.MinValue;
            double evenmax = double.MinValue;
            double oddmin = double.MaxValue;
            double evenmin = double.MaxValue;
            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    if (num > oddmax)
                    {
                        oddmax = num;
                    }
                    if (num < oddmin)
                    {
                        oddmin = num;
                    }

                    oddsum += num;
                }
                else
                {
                    if (num > evenmax)
                    {
                        evenmax = num;
                    }
                    if (num < evenmin)
                    {
                        evenmin = num;
                    }

                    evensum += num; 
                }
            }
            Console.WriteLine("OddSum:{0},", oddsum); 
            if (oddmin == double.MaxValue)
            {
                Console.WriteLine("OddMin=No");
            }
            else
            {
               Console.WriteLine("OddMin:{0},", oddmin);
            }
            if (oddmax == double.MinValue)
            {
                Console.WriteLine("Oddmax=No");
            }
            else
            {
                Console.WriteLine("OddMax:{0},", oddmax);
            }

            Console.WriteLine("EvenSum:{0},", evensum);
            if (evenmin == double.MaxValue)
            {

                Console.WriteLine("EvenMin=No");
            }
            else
            {
                Console.WriteLine("EvenMin={0}", evenmin);
            }
            if (evenmax == double.MinValue)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMax:{0}", evenmax);
            }
        }
        }
    }


