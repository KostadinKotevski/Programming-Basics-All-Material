using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Date_after_five_days
{
    class Program
    {
        static void Main(string[] args)
        {
            int Days = int.Parse(Console.ReadLine());
            int Months = int.Parse(Console.ReadLine());
            var DaysinTheMonth = 0;
            if (Months==04|| Months == 06||Months == 09||Months == 11)
            {
                DaysinTheMonth = 30;
            }
            else if (Months==02)
            {
                DaysinTheMonth = 28;
            }
            else
            {
                DaysinTheMonth = 31;
            }
            Days = Days + 5;
            if (Days>DaysinTheMonth)
            {
                Days = Days - DaysinTheMonth;
                Months = Months % 12 + 1; 
            }
            if (Months<=9)
            {
                Console.WriteLine("{0}.0{1}", Days, Months);
            }
            else
            {
                Console.WriteLine("{0}.{1}", Days, Months);
            }
        }
    }
}
