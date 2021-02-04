using System;

namespace Convert_from_Celsius_to_Farenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Temperature in Celsius: ");
            double tempC = double.Parse(Console.ReadLine());

            double tempF = (tempC * 9 / 5) + 32;

            Console.WriteLine("Temperature in Fahrenheit: " + tempF);
        }
    }
}
