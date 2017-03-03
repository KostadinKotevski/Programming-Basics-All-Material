using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Point_on_Segment
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnum = int.Parse(Console.ReadLine());
            int secondnum = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());
            int max = Math.Max(firstnum, secondnum);
            int min = Math.Min(firstnum, secondnum);
            int leftdistance = Math.Abs(point-min);
            int rightdistance = Math.Abs(max -point);
            int distance = Math.Min(leftdistance, rightdistance);
            if (firstnum<=point && secondnum>=point||firstnum>=point && secondnum<=point)
            {
                Console.WriteLine("in");
                Console.WriteLine(distance);
                
            }
            else
            {
                Console.WriteLine("out");
                Console.WriteLine(distance);
                
            }
        }
    }
}
