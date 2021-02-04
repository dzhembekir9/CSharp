using System;
// Напишете програма, която за дадена цифра (0-9), зададена като вход, извежда името на цифрата на български език.
class Program
{
    static void Main()
    {
        Console.Write("Type a number:" + " ");
        int number = int.Parse(Console.ReadLine());
        if (number == 0)
        {
            Console.WriteLine("нула");
        }
        if (number == 1)
        {
            Console.WriteLine("едно");
        }
        if (number == 2)
        {
            Console.WriteLine("две");
        }
        if (number == 3)
        {
            Console.WriteLine("три");
        }
        if (number == 4)
        {
            Console.WriteLine("четири");
        }
        if (number == 5)
        {
            Console.WriteLine("пет");
        }
        if (number == 6)
        {
            Console.WriteLine("шест");
        }
        if (number == 7)
        {
            Console.WriteLine("седем");
        }
        if (number == 8)
        {
            Console.WriteLine("осем");
        }
        if (number == 9)
        {
            Console.WriteLine("девет");
        }

    }
}

