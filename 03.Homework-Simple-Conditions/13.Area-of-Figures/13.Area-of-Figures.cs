using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            if (word=="square")
            {
                var a = double.Parse(Console.ReadLine());
                var areaofsquare = a*a;
                double after1 = Math.Round(areaofsquare,3);
                Console.WriteLine("" +after1);
            }
            else if (word == "rectangle")
            {
                var a1 = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                var areaofrectangle = a1 * b;
                double after2 = Math.Round(areaofrectangle,3); 
                Console.WriteLine(""+after2);
            }
            else if (word== "circle")
            {
                var r = double.Parse(Console.ReadLine());
                var areaofcircle = Math.PI * (r * r); 
                double after3 = Math.Round(areaofcircle, 3);
                Console.WriteLine("" + after3);
            }
            else if (word=="triangle")
            {
                var a2 = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                var areaoftriangle = (a2 * h) / 2;
                double after4 = Math.Round(areaoftriangle,3);
                Console.WriteLine("" + after4);
            }
        }
    }
}
