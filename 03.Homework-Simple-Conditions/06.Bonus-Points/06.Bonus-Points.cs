using System;

namespace _06.Bonus_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double bonusscore = 0;
            if (number <= 100)
            {
                bonusscore = 5;
            }
            else if (number >1000)
            {
                bonusscore = 0.10 * number;
            }
            else if (number > 100)
            {
                bonusscore = 0.20 * number;
            }
            if (number % 2 == 0)
            {
                bonusscore = bonusscore + 1;
            }
            else if (number % 10 == 5)
            {
                bonusscore = bonusscore + 2;
            }
            Console.WriteLine(bonusscore);
            Console.WriteLine(number + bonusscore);
        }
    }
}
