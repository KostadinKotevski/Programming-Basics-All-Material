using System;

namespace _17.Transport_Price_Past_Paper_Qus
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var timeofday = Console.ReadLine().ToLower();
            if (n<20)
            {
                if (timeofday=="day")
                {
                    Console.WriteLine(0.70 + (0.79*n));
                }
                else if (timeofday=="night")
                {
                    Console.WriteLine(0.70 + (0.90 * n));
                }     
            }
            if (n>=20 && n<100)
            {
                if (timeofday == "day")
                {
                    Console.WriteLine(0.09 * n);
                }
                else if (timeofday == "night")
                {
                    Console.WriteLine(0.09 * n);
                }
            }
            if (n>=100)
            {
                if (timeofday == "day")
                {
                    Console.WriteLine(0.06 * n);
                }
                else if (timeofday == "night")
                {
                    Console.WriteLine(0.06 * n);
                }
            }
        }
    }
}
