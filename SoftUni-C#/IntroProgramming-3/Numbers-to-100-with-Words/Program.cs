using System;

namespace Numbers_to_100_with_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("number = ");
            int number = int.Parse(Console.ReadLine());
            int number1 = 0;
            int number2 = 0;

            if (number == 100)
            {
                Console.WriteLine("one hundred");
            }
            else if (number > 100 || number < 0)
            {
                Console.WriteLine("Invalid number");
            }
            else if (number == 0 )
            {
                Console.WriteLine("zero");
            }

            string[] numbersToNineteen = new string[] {"", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
            "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};

            string[] numbersToHundred = new string[] { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };


            if (number >= 1 && number <= 19)
            {
                Console.WriteLine(numbersToNineteen[number]);
            }

            if (number >= 20 && number <= 99)
            {
                number1 = number / 10;
                number2 = number % 10;
                Console.WriteLine(numbersToHundred[number1] + numbersToNineteen[number2]);
            }

        }
    }
}
