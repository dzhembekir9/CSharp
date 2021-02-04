using System;

namespace BorderPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1 = ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("y1 = ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("x2 = ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("y2 = ");
            double y2 = double.Parse(Console.ReadLine());

            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());

            if (((x == x1 || x == x2) && (y >= y1 && y <= y2)) || ((y == y1 || y == y2) && (x >= x1 && x <= x2)))
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside/Outside");
            }
        }
    }
}
