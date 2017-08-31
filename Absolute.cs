using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter the number\n");
            x = Convert.ToInt32(Console.ReadLine());
            if(x>0)
            {
                Console.WriteLine("{0} is absulote number",x);
            }
            else
            {
                Console.WriteLine("{0} is not absolute number\n",x);
            }
            Console.ReadKey();
        }
    }
}
