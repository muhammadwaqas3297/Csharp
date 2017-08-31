using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int l, b, p, a;
            Console.WriteLine("Enter the Length of Traingle\n");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Breath of Triangle \n");
            b = Convert.ToInt32(Console.ReadLine());
            p = 2 * (l + b);
            a = (l * b);
            if (a > p)
            {
                Console.WriteLine("Area {0} is greater than Perameter",a);

            }
            else
            {
                Console.WriteLine("Perimeter {0} is greater than area",p);
            }
            Console.ReadKey();
        }
    }
}
