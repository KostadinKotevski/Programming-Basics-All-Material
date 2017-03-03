using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double priceforunder3 = 200;
            double priceforover4 = 175;
            double priceforover12 = 120;
            double sum = 0;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double m = 0;
            for (int i = 0; i < n; i++)
            {
                m = double.Parse(Console.ReadLine());

                if (m <= 3)
                {
                    sum1 = sum1 + m;
                }
                if (m>=4 && m <= 11)
                {
                    sum2 = sum2 + m;
                }
                if (m >= 12)
                {
                    sum3 = sum3 + m;
                }
                sum = sum + m; 
            }
            double average = (sum1*priceforunder3 + sum2*priceforover4 + sum3*priceforover12)/sum; 
            Console.WriteLine("{0:F2}",average);
            Console.WriteLine("{0:F2}%",(sum1/sum)*100);
            Console.WriteLine("{0:F2}%", (sum2 / sum) * 100);
            Console.WriteLine("{0:F2}%", (sum3 / sum) * 100);

        }
    }
}
