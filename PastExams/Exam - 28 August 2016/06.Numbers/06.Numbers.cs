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
            var firstDigit = n / 100;
            var secondDigit = (n / 10) % 10;
            var thirdDigit = n % 10;
            var row1 = ((n / 100) + ((n / 10) % 10));
            var col1 = ((n / 100) + (n % 10));
            for (int row = 0; row < firstDigit + secondDigit; row++)
            {
                for (int col = 0; col < firstDigit + thirdDigit; col++)
                {
                    if (n % 5 == 0)
                    {
                        n = n - firstDigit;
                        Console.Write(" " + n);
                    }
                    else if (n % 3 == 0)
                    {
                        n = n - secondDigit;
                        Console.Write(" " + n);
                    }
                    else
                    {
                        n = n + thirdDigit;
                        Console.Write(" " + n);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
