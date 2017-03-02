using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Same_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string word =Console.ReadLine().ToLower();
            string word2 = Console.ReadLine().ToLower();

            if (word==word2)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
