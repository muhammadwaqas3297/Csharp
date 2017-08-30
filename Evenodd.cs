using System;

namespace Evenodd
{
    class Evenodd
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter the Number");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
                Console.WriteLine("Number is Odd");
            Console.ReadKey();
        }
    }
}
