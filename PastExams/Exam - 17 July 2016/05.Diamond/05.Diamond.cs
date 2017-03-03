using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{2}",new string('.',n), new string('*',(n*3)), new string('.',n));
            for (int i = 0; i <= (n-2); i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}", new string('.', (n - 1) - i), new string('*', 1), new string('.', ((n * 3) + i * 2)), new string('*', 1), new string('.', (n - 1) - i));
            }
            Console.WriteLine("{0}", new string('*', n * 5));
            for (int i = 0; i <= ((n*2)-1); i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}", new string('.', ((n -(n-1)) + i)), new string('*', 1), new string('.', ((n * 5)-4) - (2 * i)), new string('*', 1), new string('.', ((n - (n-1)) + i)));
            }
            Console.WriteLine("{0}{1}{2}",new string('.',((n*2)+1)), new string ('*', n-2), new string ('.',((n*2)+1)));
        }
    }
}
