﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Program
    {
        // wryshta w sek
        static double timetosec (double h, double m, double s)
        {
            double time = h * 60 * 60 + m * 60 + s;
            return time;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("h = ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("m = ");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("s = ");
            double s = double.Parse(Console.ReadLine());
            Console.WriteLine("metri = ");
            double meters = double.Parse(Console.ReadLine());
            Console.WriteLine(meters / timetosec(h, m, s));

        }
    }
}
