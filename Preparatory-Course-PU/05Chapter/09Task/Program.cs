using System;

namespace _09Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            int num1 = number.Next(1,11);
            int num2 = number.Next(1,11);
            Console.Write("What is" + " " + num1 + " " + "times" + " " + num2 + ":" + " ");
            int ourResult = int.Parse(Console.ReadLine());
            int result = num1 * num2;
            if (result == ourResult)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
        }
    }
}
