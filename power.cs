using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace power
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, n1, n2, res;
            Console.WriteLine("Enter the value of 1st number\n");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of 2nd number\n");
            n2 = Convert.ToInt32(Console.ReadLine());
            a = n1;
            b = n2;
            while (n2 > 0)
            {
                res = res * n1;
                n2--;
            }
            Console.WriteLine("{0} is raised to the power {1} is {2}",a,b,res);
            Console.ReadKey();
        }
    }
}
