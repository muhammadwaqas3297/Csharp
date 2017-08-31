using System;


namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, x3, y1, y2, y3, m1, m2;
            Console.WriteLine("Enter the Co ordinate of 1st point (x1,y1)\n");
            Console.WriteLine("Enter the value of point x1\n");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of point y1\n");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Co ordinate of 1st point (x2,y2)\n");

            Console.WriteLine("Enter the value of point x2\n");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of point y2\n");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Co ordinate of 1st point (x3,y3)\n");
            Console.WriteLine("Enter the value of point x3\n");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of point y3\n");
            y3 = Convert.ToInt32(Console.ReadLine());
            m1 = (y2 - y1) / (x2 - x1);
            m2 = (y3 - y2) / (x3 - x2);
            if (m1 == m2)
            {
                Console.WriteLine("The given point  fall on one straight line. ");
            }
            else
            {
                Console.WriteLine("The given point does not fall on one same line");
            }
            Console.ReadKey();
        }
    }
}
