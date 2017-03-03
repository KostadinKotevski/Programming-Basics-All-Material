using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            double hoursNeeded = double.Parse(Console.ReadLine());
            double daysAvailable = double.Parse(Console.ReadLine());
            double numberofWorkers = double.Parse(Console.ReadLine());
            double timeAvailableAfterTrainning = daysAvailable - (daysAvailable * 0.10);
            double totalhoursabletowork = Math.Truncate((timeAvailableAfterTrainning * 8) + (numberofWorkers*(2*daysAvailable)));
            if (totalhoursabletowork>=hoursNeeded)
            {
                double difference = totalhoursabletowork - hoursNeeded;
                Console.WriteLine("Yes!{0} hours left.",difference);
            }
            else
            {
                double difference = totalhoursabletowork - hoursNeeded;
                Console.WriteLine("Not enough time!{0} hours needed.",Math.Abs(difference));
            }
        }
    }
}
