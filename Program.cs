using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfilLoss
{
    class Program
    {
        static void Main(string[] args)
        {
            int cost, sale;
            Console.WriteLine("Enter the Cost of Products");
            cost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Sale of Products");
            sale = Convert.ToInt32(Console.ReadLine());
            if (cost > sale)
            {
                Console.WriteLine("Loss in Busniess");
            }
            if (cost < sale)
            {
                Console.WriteLine("Profit in Busniess");
            }
            Console.ReadKey();

        }
    }
}
