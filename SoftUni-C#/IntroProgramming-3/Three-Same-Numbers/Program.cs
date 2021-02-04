using System;

namespace Three_Same_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("num 1 = ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("num 2 = ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("num 3 = ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
