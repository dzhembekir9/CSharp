using System;
//  Сортирайте 3 реални числа в намаляващ ред. Използвайте вложени if оператори.
class Program
{
    static void Main()
    {
        Console.Write("Enter first number:" + " ");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second number:" + " ");
        double number2 = double.Parse(Console.ReadLine());
        Console.Write("Enter third number:" + " ");
        double number3 = double.Parse(Console.ReadLine());
        if (number1>number2 && number1>number3)
        {
            if (number2>number3)
            {
                Console.WriteLine("{0}, {1}, {2}", number1, number2, number3);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}",number1 ,number3,number2);
            }
        }
        if (number2>number1 && number2>number3)
        {
            if (number1>number3)
            {
                Console.WriteLine("{0}, {1}, {2}",number2,number1,number3);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}",number2,number3,number1);
            }
        }
        if (number3>number1&&number3>number2)
        {
            if (number1>number2)
            {
                Console.WriteLine("{0}, {1}, {2}",number3, number1,number2);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}",number3,number2,number1);
            }
        }
    }
}

