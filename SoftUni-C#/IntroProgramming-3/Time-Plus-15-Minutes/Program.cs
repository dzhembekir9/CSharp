using System;

namespace Time_Plus_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("minutes: ");
            string minutes = Console.ReadLine();

            Console.Write("seconds: ");
            string seconds = Console.ReadLine();

            string time = minutes + ":" + seconds;

            DateTime dateTime = DateTime.Parse(time);

            dateTime = dateTime.AddMinutes(15);

            Console.Write("time after 15 minutes will be: ");
            Console.WriteLine(dateTime.ToShortTimeString());
        }
    }
}
