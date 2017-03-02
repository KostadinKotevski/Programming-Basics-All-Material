using System;

namespace _16.Number_upto_100_with_words
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var numbertens = number / 10;
            var numbersingles = number % 10;
            string singledigit = "";
            string tensdigit = "";

            if (numbertens == 10)
            {
                tensdigit = "tens";
            }
            else if (numbertens == 20)
            {
                tensdigit = "twenty";
            }
            else if (numbertens == 30)
            {
                tensdigit = "thirty";
            }
            else if (numbertens == 40)
            {
                tensdigit = "fourty";
            }
            else if (numbertens == 50)
            {
                tensdigit = "fifty";
            }
            else if (numbertens == 60)
            {
                tensdigit = "sixty";
            }
            else if (numbertens == 70)
            {
                tensdigit = "seventy";
            }
            else if (numbertens == 80)
            {
                tensdigit = "eighty";
            }
            else if (numbertens == 90)
            {
                tensdigit = "ninety";
            }

            if (number==0)
            {
                singledigit = "zero";
            }
            else if (numbersingles==1)
            {
                singledigit= "one";
            }
            else if (numbersingles==2)
            {
                singledigit= "two";
            }
            else if (numbersingles==3)
            {
                singledigit="three";
            }
            else if (numbersingles==4)
            {
                singledigit="four";
            }
            else if (numbersingles==5)
            {
                singledigit="five";
            }
            else if (numbersingles==6)
            {
                singledigit="six";
            }
            else if (numbersingles==7)
            {
                singledigit="seven";
            }
            else if (numbersingles==8)
            {
                singledigit="eight";
            }
            else if (numbersingles==9)
            {
                singledigit="nine";
            }
            Console.WriteLine(tensdigit + "" + singledigit);
        }
    }
}
