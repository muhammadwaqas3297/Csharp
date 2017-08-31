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
            int res = 12345,org;
            Console.WriteLine("Enter the 5 digit number\n");
            org = Convert.ToInt32(Console.ReadLine());
            if(res == org)
            {
                Console.WriteLine("Given Number is Reserved Number\n");

            }
            else
            {
                Console.WriteLine("Entered number is not reserved number\n");
            }
            Console.ReadKey();
        }
    }
}
