using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{2}{3}", new string('.', ((n * 3) - 2) / 2), new string('/', 1), new string('\\', 1), new string('.', ((n * 3) - 2) / 2));
            //toppart
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}", new string('.', (((n * 3) - 2) / 2)-i), new string('/', 1), new string(' ', (i*2)), new string('\\', 1), new string('.', (((n * 3) - 2) / 2) - i));
            }
            //starsrow
            Console.WriteLine("{0}{1}{2}", new string('.',(n/2)), new string('*', n*2), new string('.', n/2));
            //middlepart
            for (int i = 0; i < n*2; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}", new string('.', (n / 2)), new string('|',1), new string('\\',n+(n-2)), new string('|', 1), new string('.', (n / 2)));
            }
            // bottompart
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}", new string('.', ((n / 2)-i)), new string('/', 1), new string('*', ((n + (n - 2))+i*2)), new string('\\', 1), new string('.', ((n / 2) - i)));
            }
        }
    }
}
