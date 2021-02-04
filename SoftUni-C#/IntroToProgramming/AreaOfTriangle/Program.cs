using System;

namespace AreaOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Area is = ");
            Console.WriteLine(a * b);
        }
    }
}
