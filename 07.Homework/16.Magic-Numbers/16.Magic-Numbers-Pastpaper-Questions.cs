using System;

namespace _16.Magic_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = 100000; i < 999999; i++)
            {
                result = 1;
                int num = i;
                do
                {
                    result = result * (num % 10);
                    num = num /10;
                } while (num>0);
                if (result==n)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
