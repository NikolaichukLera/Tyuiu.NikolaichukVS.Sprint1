using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.NikolaichukVS.Sprint1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            int b = a / 4;

            b = b * (b % 3);

            a = a - (b++ - 1);

            int x = a + b;

            Console.WriteLine(a + b);




            Console.ReadKey();

        }
    }
}
