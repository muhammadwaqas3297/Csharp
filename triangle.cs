using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    class triangle
    {
        static void Main(string[] args)
        {
            int a,b,c,s;
            Console.WriteLine("Enter the 1st Angle");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2st Angle");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 3rd Angle");
            c = Convert.ToInt32(Console.ReadLine());
            s = a + b + c;
            if (s == 180)
            {
                Console.WriteLine("Triangle is Valid");
            }
            else
                Console.WriteLine("Triangle is Not Valid");
            Console.ReadKey();
        }
    }
}
