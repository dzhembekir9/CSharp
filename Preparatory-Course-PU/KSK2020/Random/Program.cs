using System;

namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Console.Write("Type n: ");
            // int n = int.Parse(Console.ReadLine());
            // for (int i = 1; i <= n; i++)
            // {
            //     Console.WriteLine(i);
            // }


            //Console.Write("Type n: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    if ((i % 3 != 0) && (i % 7 != 0))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //Console.Write("Type n: ");
            //int n = int.Parse(Console.ReadLine());
            //int a = 01;
            //int b = 1;
            //int c = 0;
            //Console.WriteLine(0);
            //Console.WriteLine(1);
            //for (int i = 1; i < n; i++)
            //{
            //    c = a + b;
            //    Console.WriteLine(c);
            //    a = b;
            //    b = c;
            //}


            //Console.Write("Type a month: ");
            //string month = Console.ReadLine();
            //switch (month)
            //{
            //    case "January": 
            //    case "March":
            //    case "May":
            //    case "July":
            //    case "August":
            //    case "Octoer":
            //    case "December":
            //        Console.WriteLine("31 days");
            //        break;
            //    case "April":
            //    case "June":
            //    case "September":
            //    case "November":
            //        Console.WriteLine("30 days");
            //        break;
            //    case "February":
            //        Console.WriteLine("28 days");
            //        break;

            //    default:
            //        Console.WriteLine("Incorrect input!");
            //        break;
            //}

            string[] Names = {"Djem", "Guven", "Adam" };
            Console.WriteLine(Names[0]);
            foreach (var item in Names)
            {
                Console.WriteLine(item);

            }


        }
    }
}
