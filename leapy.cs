using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter the year\n");
            year = Convert.ToInt32(Console.ReadLine());
            if(year%4==0)
            {
                Console.WriteLine("Entered Year {0}is Leap Year ",year);
            }
            else
            {
                Console.WriteLine("Entered year {0}is not leapyear",year);
            }
            Console.ReadKey();
        }
    }
}
