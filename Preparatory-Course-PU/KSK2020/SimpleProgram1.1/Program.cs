using System;

namespace SimpleProgram1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool backTop = true;
            while (backTop == true)
            {
                int menu;
                do
                {
                    Console.Clear();
                    Console.WriteLine("0. Exit");
                    Console.WriteLine("1. Sum Range");
                    Console.WriteLine("2. Prime Numbers");
                    Console.WriteLine("3. Factorial");
                    Console.WriteLine("4. Square Root");
                    Console.Write("Choose a number from the menu: ");
                    menu = int.Parse(Console.ReadLine());
                } while (menu < 0 || menu > 4);
                if (menu == 0)
                {
                    Console.Clear();
                    backTop = false;
                    Console.WriteLine("See you!");
                }
                if (menu == 1)
                {
                    int sum = 0;
                    int counter = 0;
                    Console.WriteLine("Please enter two numbers as a range");
                    Console.Write("a = ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("b = ");
                    int b = int.Parse(Console.ReadLine());
                    for (int i = a; i <= b; i++)
                    {
                        sum = sum + i;
                        counter++;

                    }
                    Console.WriteLine("The sum of numbers between {0} and {1} is {2}", a, b, sum);
                    double sum1 = sum / counter;
                    Console.Write("Avarage sum: ");
                    Console.WriteLine(sum1);
                    Console.Write("Do you want to return back to the menu? (yes or no) ");
                    string answer = Console.ReadLine();
                    if (answer == "yes")
                    {
                        backTop = true;
                    }
                    else if (answer == "no")
                    {
                        backTop = false;
                        Console.Clear();
                        Console.WriteLine("See you!");
                    }
                    else
                    {
                        backTop = false;
                        Console.WriteLine("Incorrect input!");
                    }


                }
                if (menu == 2)
                {
                    Console.WriteLine("Please enter two numbers as a range");
                    Console.Write("a = ");
                    int a1 = int.Parse(Console.ReadLine());
                    Console.Write("b = ");
                    int b1 = int.Parse(Console.ReadLine());
                    for (int i = 2; i < b1; i++)
                    {
                        for (int k = 2; k < b1; k++)
                        {
                            if (k % i == 1)
                            {
                                Console.WriteLine(k);
                            }
                        }
                    }
                    Console.Write("Do you want to return back to the menu? (yes or no) ");
                    string answer = Console.ReadLine();
                    if (answer == "yes")
                    {
                        backTop = true;
                    }
                    else if (answer == "no")
                    {
                        backTop = false;
                        Console.Clear();
                        Console.WriteLine("See you!");
                    }
                    else
                    {
                        backTop = false;
                        Console.WriteLine("Incorrect input!");
                    }


                }
                if (menu == 3)
                {
                    int sum = 1;
                    Console.Write("Please enter n: ");
                    int n1 = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= n1; i++)
                    {
                        sum = sum * i;
                    }
                    Console.WriteLine("{0}! is {1}", n1, sum);
                    Console.Write("Do you want to return back to the menu? (yes or no) ");
                    string answer = Console.ReadLine();
                    if (answer == "yes")
                    {
                        backTop = true;
                    }
                    else if (answer == "no")
                    {
                        backTop = false;
                        Console.Clear();
                        Console.WriteLine("See you!");
                    }
                    else
                    {
                        backTop = false;
                        Console.WriteLine("Incorrect input!");
                    }

                }
                if (menu == 4)
                {

                    Console.WriteLine("Please type a, b and c");
                    Console.Write("a = ");
                    double a2 = int.Parse(Console.ReadLine());
                    Console.Write("b = ");
                    double b2 = int.Parse(Console.ReadLine());
                    Console.Write("c = ");
                    double c = int.Parse(Console.ReadLine());
                    Console.WriteLine("D = b * b + 4 * a * c");
                    Console.WriteLine("D = " + "(" + b2 + " " + "*" + " " + b2 + ")" + " " + "-" + " " + "(" + "4" + " " + "*" + " " + a2 + " " + "*" + " " + c + ")");
                    double D = (b2 * b2) - (4 * a2 * c);
                    Console.WriteLine("D = " + D);
                    if (D > 0)
                    {
                        Console.WriteLine("D is greater than 0, so there will be two roots");
                        Console.WriteLine("x1 = ((-b) + (sqrt(D))) / (2 * a)");
                        Console.WriteLine("x1 = ((-{0}) + (sqrt({1}))) / (2 * {2})", b2, D, a2);
                        Console.WriteLine("x1 = ((-b) + (sqrt(D))) / (2 * a)");
                        Console.WriteLine("x2 = ((-{0}) + (sqrt({1}))) / (2 * {2})", b2, D, a2);
                        double x1 = ((-b2) + (Math.Sqrt(D))) / (2 * a2);
                        double x2 = ((-b2) - (Math.Sqrt(D))) / (2 * a2);
                        Console.WriteLine("x1 = {0}", x1);
                        Console.WriteLine("x2 = {0}", x2);
                    }
                    if (D == 0)
                    {
                        Console.WriteLine("D is equal to zero, so x1 will be equal to x2");
                        Console.WriteLine("x1 = x2 = -b / (2 * a)");
                        Console.WriteLine("x1 = x2 = -{0} / (2 * {1})", b2, a2);
                        double x1 = (-b2) / (2 * a2);
                        Console.Write("x1 = x2 = {0}", x1);
                        Console.WriteLine(x1);
                    }
                    if (D < 0)
                    {
                        Console.WriteLine("D is lower than zero, so there are not any roots");
                    }
                    Console.Write("Do you want to return back to the menu? (yes or no) ");
                    string answer = Console.ReadLine();
                    if (answer == "yes")
                    {
                        backTop = true;
                    }
                    else if (answer == "no") 
                    {
                        backTop = false;
                        Console.Clear();
                        Console.WriteLine("See you!");
                    }
                    else
                    {
                        backTop = false;
                        Console.WriteLine("Incorrect input!");
                    }

                }

            }

        }
    }
}
