using System;
//Напишете програма, която намира най-голямото по стойност число измежду дадени 5 числа.
class Program
{
    static void Main()
    {
        Console.Write("a = ");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double number2 = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double number3 = double.Parse(Console.ReadLine());
        Console.Write("d = ");
        double number4 = double.Parse(Console.ReadLine());
        Console.Write("e = ");
        double number5 = double.Parse(Console.ReadLine());
        if (number1>number2 && number1>number3&&number1>number4&&number1>number5)
        {
            Console.WriteLine("Number {0} is the greatest",number1);
        }
        if (number2>number1&&number2>number3&&number2>number4&&number2>number5)
        {
            Console.WriteLine("Number {0} is the greatest", number2);
        }
        if (number3>number1&&number3>number2&&number3>number4&&number3>number5)
        {
            Console.WriteLine("Number {0} is the greatest", number3);
        }
        if (number4>number1&&number4>number2&&number4>number3&&number4>number5)
        {
            Console.WriteLine("Number {0} is the greatest",number4);
        }
        if (number5 > number1 && number5 > number2 && number5 > number3 && number5 > number4)
        {
            Console.WriteLine("Number {0} is the greatest", number5);
        }
    }
}

