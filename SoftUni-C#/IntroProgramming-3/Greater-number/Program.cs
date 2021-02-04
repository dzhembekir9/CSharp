using System;

namespace Greater_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("num 1 = ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("num 2 = ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("num 1 ({0}) is greater than num 2 ({1})",num1,num2);
            }
            else if (num2 > num1)
            {
                Console.WriteLine("num 2 ({0}) is greater than num 1 ({1})", num2, num1);
            }
            
        }
    }
}
