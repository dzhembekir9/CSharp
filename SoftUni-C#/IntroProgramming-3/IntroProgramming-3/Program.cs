using System;

namespace IntroProgramming_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Grade = ");
            var grade = double.Parse(Console.ReadLine());

            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
