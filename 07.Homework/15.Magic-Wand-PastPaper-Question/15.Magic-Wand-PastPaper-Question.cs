using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Magic_Wand_PastPaper_Question
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int bigger = 1;
            int c = 97;
            int d = 97;
            for (int a = 1; a < n; a++)
            {
                for (int b = 1; b < n; b++)
                {
                    for (int c1= 0; c1 < l; c1++)
                    {
                        for (int d1 = 0; d1 < l; d1++)
                        {
                            if (a > b)
                            {
                                bigger = a + 1;
                            }
                            else
                            {
                                bigger = b + 1;
                            }
                            for (int o = bigger; o <=n; o++)
                            {
                                Console.Write("{0}{1}", a, b);
                                string simbol3 = Char.ConvertFromUtf32(c + c1);
                                string simbol4 = Char.ConvertFromUtf32(d + d1);
                                Console.Write("{0}{1}", simbol3, simbol4);
                                Console.Write("{0} ", o);
                            }
                        }
                    }
                }
            }
        }
    }
}
