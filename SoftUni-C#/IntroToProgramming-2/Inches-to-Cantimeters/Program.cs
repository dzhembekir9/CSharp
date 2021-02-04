using System;

namespace Inches_to_Cantimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a (inches) = ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("a (cantimeters) = " + a * 2.54);
        }
    }
}
