using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_of_Seconds_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstRunner = int.Parse(Console.ReadLine());
            int SecondRunner = int.Parse(Console.ReadLine());
            int ThirdRunner = int.Parse(Console.ReadLine());
            int totalSeconds = firstRunner + SecondRunner + ThirdRunner;
            var minutes = 0.0;
            if (totalSeconds<60)
            {

            }
            else if (totalSeconds< 120)
            {
                totalSeconds -=60;
                minutes += 1;
            }
            else if (totalSeconds<180)
            {
                totalSeconds -= 120;
                minutes += 2;
            }
            if (totalSeconds<10)
            {
                Console.WriteLine("{0}:0{1}", minutes, totalSeconds);
            }
            else
            {
                Console.WriteLine("{0}:{1}", minutes, totalSeconds);
            }
        }
    }
}
