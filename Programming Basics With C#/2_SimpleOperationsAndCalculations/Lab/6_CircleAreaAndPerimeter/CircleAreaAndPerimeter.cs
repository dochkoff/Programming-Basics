﻿using System;

namespace CircleAreaAndPerimeter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * radius * radius;
            Console.WriteLine("Area = " + area);

            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine("Perimeter = " + perimeter);
        }
    }
}
