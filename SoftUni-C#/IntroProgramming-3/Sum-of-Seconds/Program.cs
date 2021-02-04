using System;

namespace Sum_of_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("time 1 = ");
            int t1 = int.Parse(Console.ReadLine());

            Console.Write("time 2 = ");
            int t2 = int.Parse(Console.ReadLine());

            Console.Write("time 3 = ");
            int t3 = int.Parse(Console.ReadLine());

            int totalTime = t1 + t2 + t3;

            if (totalTime < 60)
            {
                Console.WriteLine("0:" + totalTime);
            }
            else if (totalTime >= 60 && totalTime < 120)
            {
                Console.Write("1:");
                totalTime = totalTime - 60;
                if (totalTime < 10)
                {
                    Console.WriteLine("0" + totalTime);
                }
                else
                {
                    Console.WriteLine(totalTime);
                }
            }
            else if (totalTime >= 120)
            {
                Console.Write("2:");
                totalTime = totalTime - 120;
                if (totalTime < 10)
                {
                    Console.WriteLine("0" + totalTime);
                }
                else
                {
                    Console.WriteLine(totalTime);
                }
            }

        }
    }
}
