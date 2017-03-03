using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            var ivanAge = 18;
            double years = double.Parse(Console.ReadLine());
            for (int i = 1800; i <= years; i++)
            {
                if (i%2==0)
                {
                    money -=  12000;
                }
                else
                {
                    money -= (12000 + ivanAge * 50);
                }
                ivanAge++;
            }
            if (money>=0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", money);
            }
            else
            {
                Console.WriteLine("He will need {0:F2} dollars to survive.", Math.Abs(money));
            }
        }
    }
}
