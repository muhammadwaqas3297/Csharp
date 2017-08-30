using System;

namespace SumofNum
{
    class SumofNum
    {
        static void Main(string[] args)
        {
            int Num,sum=0,digit;
            Console.WriteLine("Enter the Number");
            Num = Convert.ToInt32(Console.ReadLine());
            while (Num > 0)
            {
                digit = Num % 10;
                sum = sum + digit;
                Num /= 10;
            }

            Console.WriteLine("{0}",sum);
            Console.ReadKey();
        }
    }
}
