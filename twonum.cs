using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter 1st Number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Volume of a={0},b={1}",a,b);
            Console.ReadKey();
        }
    }
}
