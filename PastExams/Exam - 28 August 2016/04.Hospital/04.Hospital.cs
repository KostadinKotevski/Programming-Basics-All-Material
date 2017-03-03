using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treated = 0;
            int untreated = 0; 
            for (int i = 1; i <= days; i++)
            {
                int patients = int.Parse(Console.ReadLine());
                if ((i % 3 == 0) && (untreated>treated))
                {
                    doctors++;
                }
                if (patients > doctors)
                {
                    treated = treated + doctors;
                    untreated = untreated + (patients - doctors);
                }
                else
                {
                    treated = treated + patients;
                }
            }

            Console.WriteLine("Treated patients: {0}.", treated);
            Console.WriteLine("Untreated patients: {0}.", untreated);
        }
        }
    }

