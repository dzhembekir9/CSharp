using System;

namespace Even_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("number = ");
            double number = double.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
