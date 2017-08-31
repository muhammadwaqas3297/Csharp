using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Let_us_C_chap3
{
    class OverTime
    {
        static void Main(string[] args)
        {
            for(int employee = 1;employee<=10;employee++)
            {
                Console.WriteLine("enter hours worked for {0} employees",employee);
                int hours = Convert.ToInt32(Console.ReadLine());
                int FixedTime = 40;
                int overtime,opay;
                if(hours>40)
                {
                    overtime = hours - FixedTime;
                    opay = overtime * 1200;

                    Console.WriteLine("overtime pay is {0}",opay);


                }

                else
                {
                    Console.WriteLine("there is no overtime pay");
                }
            }

            Console.ReadKey();
        }
    }
}
