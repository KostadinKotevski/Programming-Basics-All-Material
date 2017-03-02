using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            var weekendsforvolley = 48;
            var resultminushome = weekendsforvolley - h;
            var saturdaygamessofia = resultminushome * (3.0 / 4);
            var holidaygamesinsofia = p * (2.0/3);
            var numberofgamestotalgames = saturdaygamessofia + h + holidaygamesinsofia;
            var additionalgamesinleapyear = -1.0;
            var finalresult = -1.0;
            var finalresult1 = -1.0;
            if (year == "leap")
            {
                additionalgamesinleapyear = numberofgamestotalgames * 0.15;
                finalresult = additionalgamesinleapyear+numberofgamestotalgames;
                finalresult = Math.Truncate(finalresult);
                Console.WriteLine(finalresult);
            }
            else if (year == "normal")
            {
                finalresult1 = numberofgamestotalgames;
                finalresult1 = Math.Truncate(finalresult1);
                Console.WriteLine(finalresult1);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
