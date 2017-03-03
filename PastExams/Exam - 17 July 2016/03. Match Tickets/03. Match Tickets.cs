using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var VIP = 499.99;
            var Normal = 249.99;
            double Money= double.Parse(Console.ReadLine());
            string ticket = Console.ReadLine(); 
            double people= double.Parse(Console.ReadLine());
            if (people <= 4)
            {
                var transport = Money * 0.75;
                var result = Money - transport;
                if (ticket == "VIP" && result > 0)
                {
                    var finalresult1 = result - (people * VIP);
                    if (finalresult1 >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:F2} leva left.", finalresult1);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(finalresult1));
                    }
                }
                else if (ticket == "Normal" && result > 0)
                {
                    var finalresult1 = result - (people * Normal);
                    if (finalresult1 >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:F2} leva left.", finalresult1);
                    }
                    else
                    {

                        Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(finalresult1));
                    }
                }
            }
            else if (people >= 5 && people <= 9)
            {
                var transport1 = Money * 0.60;
                var result1 = Money - transport1;
                if (ticket == "VIP" && result1 > 0)
                {
                    var finalresult1 = result1 - (people * VIP);
                    if (finalresult1 >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:F2} leva left.", finalresult1);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(finalresult1));
                    }
                }
                else if (ticket == "Normal" && result1 > 0)
                {
                    var finalresult1 = result1 - (people * Normal);
                    if (finalresult1 >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:F2} leva left.", finalresult1);
                    }
                    else
                    {

                        Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(finalresult1));
                    }
                }
            }
            else if (people >= 10 && people <= 24)
            {
                var transport2 = Money * 0.50;
                var result2 = Money - transport2;
                if (ticket == "VIP" && result2 > 0)
                {
                    var finalresult1 = result2 - (people * VIP);
                    if (finalresult1 >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:F2} leva left.", finalresult1);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(finalresult1));
                    }
                }
                else if (ticket == "Normal" && result2 > 0)
                {
                    var finalresult1 = result2 - (people * Normal);
                    if (finalresult1 >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:F2} leva left.", finalresult1);
                    }
                    else
                    {

                        Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(finalresult1));
                    }
                }
            }
            else if (people >= 25 && people <= 49)
            {
                var transport3 = Money * 0.40;
                var result3 = Money - transport3;
                if (ticket == "VIP" && result3 > 0)
                {
                    var finalresult1 = result3 - (people * VIP);
                    if (finalresult1 >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:F2} leva left.", finalresult1);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(finalresult1));
                    }
                }
                else if (ticket == "Normal" && result3 > 0)
                {
                    var finalresult1 = result3 - (people * Normal);
                    if (finalresult1 >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:F2} leva left.", finalresult1);
                    }
                    else
                    {

                        Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(finalresult1));
                    }
                }
            }
            else if (people >= 50)
            {
                var transport4 = Money * 0.25;
                var result4 = Money - transport4;
                if (ticket == "VIP" && result4> 0)
                {
                    var finalresult1 = result4- (people * VIP);
                    if (finalresult1 >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:F2} leva left.", finalresult1);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(finalresult1));
                    }
                }
                else if (ticket == "Normal" && result4> 0)
                {
                    var finalresult1 = result4- (people * Normal);
                    if (finalresult1 >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:F2} leva left.", finalresult1);
                    }
                    else
                    {

                        Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(finalresult1));
                    }
                }
            }
        }
    }
}
