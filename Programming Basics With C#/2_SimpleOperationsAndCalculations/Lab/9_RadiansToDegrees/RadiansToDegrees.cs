﻿using System;

namespace RadiansToDegrees
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double deg = rad * 180 / Math.PI;
            Console.WriteLine(Math.Round(deg));
        }
    }
}
