using System;

namespace Convert_from_USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("USD: ");
            double usd = double.Parse(Console.ReadLine());

            double bgn = usd * 1.79549;

            Console.WriteLine("BGN: " + Math.Round(bgn,2,MidpointRounding.AwayFromZero) + " BGN");
        }
    }
}
