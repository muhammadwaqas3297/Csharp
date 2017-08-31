using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, fact=1;
            Console.WriteLine("Enter any number to find its factorial value\n");
            num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                fact = fact * num;
                num = num - 1;
            }
            Console.WriteLine("\nFactorial value is {0}",fact);
            Console.ReadKey();
        }
    }
}
