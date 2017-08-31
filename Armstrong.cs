using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Let_us_C_chap3
{
    class Armstrong
    {
        static void Main(string[] args)
        {
            int n, n1, rem, num = 0;
            Console.WriteLine("Enter a positive  integer: ");
            n = Int32.Parse(Console.ReadLine());
            n1 = n;
            while (n1 != 0)
            {
                rem = n1 % 10;
                num += rem * rem * rem;
                n1 /= 10;
            }
            if (num == n)
            {
                Console.WriteLine("{0} is an Armstrong number.", n);
            }
            else
            {
                Console.WriteLine("{0} is not an Armstrong number.", n);
            }
            Console.ReadKey();
        }
    }
}
