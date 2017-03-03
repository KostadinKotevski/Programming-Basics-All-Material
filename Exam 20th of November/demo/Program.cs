using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            for (int y = 0; y < max; y++)
            {
                for (int i = n; i <= n; i++)
                {
                    for (int j = n; j <= m; j++)
                    {
                        Console.Write("<{0}-{1}>", i, j);
                        Console.Write("<{0}-{1}>", j, i);
                    }
                }
            }
        }
    }
}
