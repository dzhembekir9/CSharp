using System;
// Напишете програма, която прилага бонус точки към дадени точки в интервала [1..9] чрез прилагане на следните правила:

// -  Ако точките са между 1 и 3, програмата ги умножава по 10.

// -  Ако точките са между 4 и 6, ги умножава по 100

// -  Ако точките са между 7 и 9, ги умножава по 1000.

// -  Ако точките са 0 или повече от 9, се отпечатва съобщение за грешка.
class Program
{
    static void Main()
    {
        Console.Write("Type your points:" + " ");
        int points = int.Parse(Console.ReadLine());
        if (points > 0 && points < 10)
        {
            if (points >= 1 && points <= 3)
            {
                points = points * 10;
            }
            if (points >= 4 && points <= 6)
            {
                points = points * 100;
            }
            if (points >= 7 && points <= 9)
            {
                points = points * 1000;
            }
            Console.WriteLine("Bonus points:" + " " + points);
        }
        else
        {
            Console.WriteLine("Error!");
            Console.WriteLine("You must type a number between 0 and 9!");
        }
    }
}

