﻿using System;
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
            int a = 2;

            int b = a - 3;

            int c = a + 1;

            a = b + a - c;

            c -= b + a;

            b += a - 1;

            Console.WriteLine(a + b + c);




            Console.ReadKey();

        }
    }
}
