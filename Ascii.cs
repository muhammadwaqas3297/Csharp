using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Let_us_C_chap3
{
    class Ascii
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine("{0} = {1}", i, (char)i);
            }
            Console.ReadKey();
        }
    }
}
