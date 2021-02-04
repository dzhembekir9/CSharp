using System;

namespace Bonus_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("number = ");
            double number = int.Parse(Console.ReadLine());
            double bonusPoints = 0.0;

            if (number <= 100)
            {
                bonusPoints += 5;
            }

            if (number > 1000)
            {
                bonusPoints += number * 0.10;
            }
            else if (number > 100)
            {
                bonusPoints += number * 0.20;
            }

            if (number % 2 == 0)
            {
                bonusPoints = bonusPoints + 1;
            }
            else if (number % 5 == 0 && number % 10 != 0)
            {
                bonusPoints += 2;
            }

            number = number + bonusPoints;
            number = Math.Round(number, 1);
            bonusPoints = Math.Round(bonusPoints, 1);
            Console.WriteLine("Number = " + number);
            Console.WriteLine("Bonus points = " + bonusPoints);
        }
    }
}
