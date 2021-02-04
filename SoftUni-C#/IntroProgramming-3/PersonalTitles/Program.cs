using System;

namespace PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("gender: ");
            string gender = Console.ReadLine();

            Console.Write("age: ");
            int age = int.Parse(Console.ReadLine());

            if (gender == "m")
            {
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else if (age < 16)
                {
                    Console.WriteLine("Master");
                }
            }
            else if (gender == "f")
            {
                if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else if (age < 16)
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}
