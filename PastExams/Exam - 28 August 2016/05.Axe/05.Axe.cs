using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double n2 = n / 2;
            double n1 = Math.Truncate(n2);
            Console.WriteLine("{0}{1}{2}", new string('-', n * 3), new string('*', 2), new string('-', (n * 2) - 2));
            for (int i = 1; i <= n + 1; i++)
            {
                if (i < n)
                {
                    Console.WriteLine("{0}{1}{2}{3}{4}", new string('-', n * 3), new string('*', (n - (n - 1))), new string('-', i), new string('*', (n - (n - 1))), new string('-', ((n * 2) - 2) - i));
                }
            }
            for (int i = 1; i <= n1; i++)
            {
                Console.WriteLine(new string('*', (n * 3) + 1) + new string('-', n - 1) + "*" + new string('-', n - 1));
            }
            for (int i = 0; i < n1; i++)
            {
                if (i!= n1 - 1)
                {
                    Console.WriteLine("{0}{1}{2}{3}{4}", new string('-', (n * 3) - i), new string('*', 1), new string('-', (n - 1) + i + i), new string('*', 1), new string('-', (n - 1) - i));
                }
                else
                {

                    Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n - i),
                                                     new string('*', n - 1 + 2 * i),
                                                     new string('-', (n - 1 - i)));
                }
            }
        }
    }
    }
