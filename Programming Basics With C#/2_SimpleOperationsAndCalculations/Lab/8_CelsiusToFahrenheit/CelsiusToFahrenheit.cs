﻿using System;

namespace CelsiusToFahrenheit
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double c = double.Parse(Console.ReadLine());
            double f = c * 1.8 + 32;
            Console.WriteLine($"{f:F2}");
        }
    }
}
