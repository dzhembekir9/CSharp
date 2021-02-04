using System;
// Напишете програма, която намира най-голямото по стойност число, измежду три дадени числа.
class Program
{
    static void Main()
    {
        Console.Write("Enter first number:"+" ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number:"+" ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("Enter third number:"+" ");
        int number3 = int.Parse(Console.ReadLine());
        if (number1 > number2 && number1 > number3)
        {
            Console.WriteLine("Number {0} is the greatest",number1);
        }
        if (number2>number1 && number2>number3)
        {
            Console.WriteLine("Number {0} is the greatest",number2);
        }
        if (number3>number2 && number3>number1)
        {
            Console.WriteLine("Number {0} is the greatest",number3);
        }
    }
}
