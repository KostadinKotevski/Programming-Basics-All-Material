using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            if (month =="May"|| month == "October")
            {
                double studioprice = 50;
                double apartmentprice = 65;
                if (days<=7)
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", apartmentprice * days);
                    Console.WriteLine("Studio: {0:F2} lv.", studioprice *days);
                }
                else if (days>7 && days<=14)
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", apartmentprice * days);
                    Console.WriteLine("Studio: {0:F2} lv.", days * (studioprice - (studioprice * 0.05)));
                }
                else if (days>14)
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", days * (apartmentprice - (apartmentprice * 0.10)));
                    Console.WriteLine("Studio: {0:F2} lv.", days * (studioprice - (studioprice * 0.30)));
                }
            }
            if (month == "June" || month == "September")
            {
                double studioprice = 75.2;
                double apartmentprice = 68.7;
                if (days<=14)
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", apartmentprice * days);
                    Console.WriteLine("Studio: {0:F2} lv.", studioprice * days);
                }
                else if (days>14)
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", days * (apartmentprice - (apartmentprice * 0.10)));
                    Console.WriteLine("Studio: {0:F2} lv.", days * (studioprice - (studioprice * 0.20)));
                }
            }
            if (month == "July" || month == "August")
            {
                double studioprice = 76;
                double apartmentprice = 77;
                if (days<=14)
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", apartmentprice * days);
                    Console.WriteLine("Studio: {0:F2} lv.", studioprice * days);
                }
                else if (days>14)
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", days * (apartmentprice - (apartmentprice * 0.10)));
                    Console.WriteLine("Studio: {0:F2} lv.", studioprice * days);
                }
            } 
        }
    }
}
