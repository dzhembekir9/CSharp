using System;

namespace Convert_from_radians_to_degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Radians = ");
            double rad = double.Parse(Console.ReadLine());

            double deg = rad * (180 / Math.PI);

            Console.WriteLine("Degrees = " + (int)deg);
        }
    }
}
