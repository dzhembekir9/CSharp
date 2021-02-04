using System;

namespace SimpleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a topic from the menu!");
            Console.WriteLine("1. Simple calculator");
            Console.WriteLine("2. Fibonacci");
            Console.WriteLine("3. Prime numbers");
            Console.WriteLine("4. Reverse numbers");
            int menu = int.Parse(Console.ReadLine());
            if (menu == 1)
            {
                Console.WriteLine("You chose simple calculator!");
                Console.WriteLine("Type two numbers!");
                Console.Write("First number: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Second number: ");
                double num2 = double.Parse(Console.ReadLine());
                double pro = num1 * num2;
                double raz = num1 - num2;
                double sbor = num1 + num2;
                double del = num1 / num2;
                Console.WriteLine("{0} * {1} = {2}", num1, num2, pro);
                Console.WriteLine("{0} + {1} = {2}", num1, num2, sbor);
                Console.WriteLine("{0} - {1} = {2}", num1, num2, raz);
                Console.WriteLine("{0} / {1} = {2}", num1, num2, del);

            }
            if (menu == 2)
            {
                Console.WriteLine("You chose Fibonacci numbers!");
                Console.Write("Enter a number: ");
                int n = int.Parse(Console.ReadLine());
                int num1 = 0;
                int num2 = 1;
                int num3;
                Console.WriteLine(num1);
                Console.WriteLine(num2);
                for (int i = 2; i < n; i++)
                {
                    num3 = num1 + num2;
                    Console.WriteLine(num3);
                    num1 = num2;
                    num2 = num3;
                }

            }
            if (menu == 3)
            {
                Console.WriteLine("You chose prime numbers!");
                Console.WriteLine("Those are the prime numbers from 2 to 1000");
                Console.WriteLine(2);
                for (int i = 2; i < 1001; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            if (menu == 4)
            {

            }
        }
    }
}
