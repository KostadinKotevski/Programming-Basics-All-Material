using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Guess_the_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string password = "s3cr3t!P@ssw0rd";
            if (a==password)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong Password!");
            }
        }
    }
}
