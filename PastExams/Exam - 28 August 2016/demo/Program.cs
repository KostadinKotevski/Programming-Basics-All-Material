using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var result = 0;
            var row1 = ((n / 100) + ((n / 10) % 10));
            var col1 = ((n / 100) + (n % 10));
            for (int row = 1; row <= row1; row++)
            {
                for (int col = 1; col <= col1; col++)
                {
                    do
                    {
                        if (n % 5 == 0)
                        {
                            result = n - (n / 100);
                        }
                        else if (n % 3 == 0)
                        {
                            var secondnumber = n / 10;
                            result = n - (secondnumber % 10);
                        }
                        else
                        {
                            result = n - (n % 10);

                        }
                        n++;
                        Console.Write(" " + result++);
                    } while (result);
                }
                Console.WriteLine();
            }
        }
    }
}
