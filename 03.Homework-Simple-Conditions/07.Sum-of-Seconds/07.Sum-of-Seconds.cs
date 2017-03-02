using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_of_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var sec1 = int.Parse(Console.ReadLine());
            var sec2 = int.Parse(Console.ReadLine());
            var sec3 = int.Parse(Console.ReadLine());
            var secsum = sec1 + sec2 + sec3;
            var min = 0;
            if (secsum >= 59)
            {
                if (secsum <= 9)
                {
                    Console.WriteLine("0:0{0}"+secsum);
                }
                else
                {
                    Console.WriteLine("0:{0}"+secsum);
                }
            }
            else if (secsum <= 119)
            {
                if (secsum <= 69)
                {
                    Console.WriteLine("1:0{0}", secsum - 60);
                }
                else
                {
                    Console.WriteLine("1:{0}", secsum - 60);
                }
            }
            else if (secsum <= 179)
            {
                if (secsum <= 129)
                {
                    Console.WriteLine("2:0{0}", secsum - 120);
                }
                else
                {
                    Console.WriteLine("2:{0}", secsum - 120);
                }
            }
        }
    }
}// dovar6i

