using System;

namespace Convertor_for_Units_of_Measurment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("number = ");
            double number = int.Parse(Console.ReadLine());

            Console.Write("From: ");
            string from = Console.ReadLine();

            Console.Write("To: ");
            string to = Console.ReadLine();

            //LOGIC FOR METERS

            if (from == "m" && to == "mm")
            {
                number = number * 1000;
            }
            else if (from == "m" && to == "cm")
            {
                number = number * 100;
            }
            else if (from == "m" && to == "mi")
            {
                number = number * 0.000621371192;
            }
            else if (from == "m" && to == "in")
            {
                number = number * 39.3700787;
            }
            else if (from == "m" && to == "km")
            {
                number = number * 0.001;
            }
            else if (from == "m" && to == "ft")
            {
                number = number * 3.2808399;
            }
            else if (from == "m" && to == "yd")
            {
                number = number * 1.0936133;
            }

            //TODO: INPUT LOGIC FOR OTHER UNITS OF MEASURMENT...


            Console.WriteLine(number);
        }
    }
}
