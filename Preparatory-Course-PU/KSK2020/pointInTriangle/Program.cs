using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleXY
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1 = ");
            var xone = double.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            var yone = double.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            var xtwo = double.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            var ytwo = double.Parse(Console.ReadLine());
            Console.Write("x = ");
            var x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            var y = double.Parse(Console.ReadLine());
            if (xone < xtwo && yone < ytwo)
            {
                if (x >= xone && x <= xtwo && yone >= yone && y <= ytwo)
                {
                    Console.WriteLine("Inside");
                }
                else
                {
                    Console.WriteLine("Outside");
                }
            }
        }
    }
}
