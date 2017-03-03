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
            int counter = 0;
            bool shouldbreak = false;   
            for (int i = n; i <= m ; i++)
            {
                if (shouldbreak== true)
                {
                    break;
                }
                for (int j = n; j <=m ; j++)
                {
                    Console.Write("<{0}-{1}>", i,j);
                    counter++;
                    if (counter>= max)
                    {
                        shouldbreak = true;
                        break;
                    }
                } 
            }
       }
    }
}

