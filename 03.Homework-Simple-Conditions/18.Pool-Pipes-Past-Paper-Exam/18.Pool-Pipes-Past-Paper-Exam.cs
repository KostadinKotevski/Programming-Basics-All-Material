using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Pool_Pipes_Past_Paper_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var V = double.Parse(Console.ReadLine());
            var P1 = double.Parse(Console.ReadLine());
            var P2 = double.Parse(Console.ReadLine());
            var H = double.Parse(Console.ReadLine());
            var pipeone = (P1 * H);
            var pipetwo = (P2 * H);
            var sum = pipeone + pipetwo;
            var persentofpullfull = Math.Truncate((sum / V) * 100); 
            var pipeonepersent = Math.Truncate((pipeone / sum) * 100); 
            var pipetwopersent = Math.Truncate((pipetwo / sum) * 100);
            var overflow = sum - V;
            if (sum<=V)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",persentofpullfull,pipeonepersent,pipetwopersent);
            }
            else if (sum>=V)
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",H,overflow);
            }
        }
    }
}
