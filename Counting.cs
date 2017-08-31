using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Let_us_C_chap3
{
    class Counting
    {
        static void Main(string[] args)
        {
            string s = "yes";

            int num,gcount = 0,scount = 0,zcount = 0;

            while(s == "yes")
            {
                Console.WriteLine("enter a number ");
                num = Int32.Parse(Console.ReadLine());
                
                if(num>0)
                {
                    gcount++;
                }
                else if (num < 0)
                {
                    scount++;
                }
                else
                {
                    zcount++;
                }

                Console.WriteLine("Do you want to continue? yes/no");
                s = Console.ReadLine();
            }
            Console.WriteLine("you entered {0} positive number \n {1} negative number \n {2} zero ",gcount,scount,zcount);

            Console.ReadKey();
        }
    }
}
