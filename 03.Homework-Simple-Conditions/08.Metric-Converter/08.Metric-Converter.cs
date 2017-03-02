using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var SourseMetric = Console.ReadLine().ToLower();
            var EndMetric = Console.ReadLine().ToLower();
            double meters = 0.0;
            if (SourseMetric =="mm")
            {
                number = number/1000;
            }
            else if (SourseMetric == "cm")
            {
                number = number/100;
            }
            else if (SourseMetric == "mi")
            {
                number = number/0.000621371192;
            }
            else if (SourseMetric == "in")
            {
                number = number/39.3700787;
            }
            else if (SourseMetric == "km")
            {
                number = number/0.001;
            }
            else if (SourseMetric == "ft")
            {
                number = number/3.2808399;
            }
            else if (SourseMetric == "yd")
            {
                number = number/1.0936133;
            }
            if (EndMetric == "mm")
            {
                number = number*1000;
            }
            else if (EndMetric == "cm")
            {
                number = number*100;
            }
            else if (EndMetric == "mi")
            {
                number = number*0.000621371192;
            }
            else if (EndMetric == "in")
            {
                number = number*39.3700787;
            }
            else if (EndMetric == "km")
            {
                number = number*0.001;
            }
            else if (EndMetric == "ft")
            {
                number = number*3.2808399;
            }
            else if (EndMetric == "yd")
            {
                number = number*1.0936133;
            }
            Console.WriteLine(number + " " + EndMetric);
        }
    }
}
