using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Oversleeping_Cat_Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            var holidaydays = int.Parse(Console.ReadLine());
            var playingminutesyearly = ((365 - holidaydays) * 63) + (holidaydays*127);
            var result = Math.Abs(playingminutesyearly-30000);
            int hour = result / 60;
            int minutes = result % 60;
            if (playingminutesyearly>30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hour, minutes);
            }
            else if (playingminutesyearly<30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hour, minutes);
            }
        }
    }
}
