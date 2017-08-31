using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter the value of X coordinate\n");
            x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y coordinate\n");
            y = Convert.ToInt32(Console.ReadLine());
            if (x == 0 && y == 0)
            {
                Console.WriteLine("The point lies at origin ");
            }
            else if(y==0&&x!=0)

            {
                Console.WriteLine("The point is at x Axis");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("The point is at yaxis");
            }
            else if (x != 0 && y != 0)
            {
                Console.WriteLine("The point is in the middle of graph");
            }

            Console.ReadKey();
        }
    }
}
