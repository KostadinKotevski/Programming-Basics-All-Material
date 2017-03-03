using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Special_Numbers_PastPaper_Question
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int a = 1; a < 9; a++)
            {
                for (int b = 1;  b < 9;  b++)
                {
                    for (int c = 1; c < 9; c++)
                    {
                        for (int i = 1; i < 9; i++)
                        {
                            if (n%a==0 && n%b==0 && n%c==0 && n%i==0)
                            {
                                Console.Write("{0}{1}{2}{3} ",a,b,c,i);
                            }
                        }
                    }
                }
            }
        }
    }
}
