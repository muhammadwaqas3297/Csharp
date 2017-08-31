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
            int a, b,c,d;
            Console.WriteLine("Enter 1st Number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3st Number");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 4nd Number");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Valume of a={0},b={1},c={2},d={3}",a,b,c,d);
            Console.WriteLine("A=" + a+"\t B=" + b+"\nC=" + c+"\t D=" + d);
            Console.ReadKey();
        }
    }
}
