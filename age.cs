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
            int ram, shayam, ajay;
            Console.WriteLine("Enter the age of Ram\n");
            ram = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the age of Shayam\n");
            shayam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the age of ajay\n");
            ajay = Convert.ToInt32(Console.ReadLine());
            if(ram<shayam)
            {
                if(ram<ajay)
                {
                    Console.WriteLine("Ram is youngest\n");
                }
                else
                {
                    Console.WriteLine("Ajay is Youngest\n");
                }
            }
            else
            {
                if(shayam<ajay)
                {
                    Console.WriteLine("Shayam is youngest\n");
                }
                else
                {
                    Console.WriteLine("Ajay is youngest\n");
                }
                
            }
            Console.ReadKey();
        }
    }
}
