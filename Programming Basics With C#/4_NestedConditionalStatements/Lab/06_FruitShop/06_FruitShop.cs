﻿using System;

namespace FruitShop
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string weekDay = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            switch (weekDay)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            Console.WriteLine($"{quantity * 2.5:F2}");
                            break;
                        case "apple":
                            Console.WriteLine($"{quantity * 1.2:F2}");
                            break;
                        case "orange":
                            Console.WriteLine($"{quantity * 0.85:F2}");
                            break;
                        case "grapefruit":
                            Console.WriteLine($"{quantity * 1.45:F2}");
                            break;
                        case "kiwi":
                            Console.WriteLine($"{quantity * 2.7:F2}");
                            break;
                        case "pineapple":
                            Console.WriteLine($"{quantity * 5.5:F2}");
                            break;
                        case "grapes":
                            Console.WriteLine($"{quantity * 3.85:F2}");
                            break;
                        default: Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            Console.WriteLine($"{quantity * 2.7:F2}");
                            break;
                        case "apple":
                            Console.WriteLine($"{quantity * 1.25:F2}");
                            break;
                        case "orange":
                            Console.WriteLine($"{quantity * 0.9:F2}");
                            break;
                        case "grapefruit":
                            Console.WriteLine($"{quantity * 1.6:F2}");
                            break;
                        case "kiwi":
                            Console.WriteLine($"{quantity * 3:F2}");
                            break;
                        case "pineapple":
                            Console.WriteLine($"{quantity * 5.6:F2}");
                            break;
                        case "grapes":
                            Console.WriteLine($"{quantity * 4.2:F2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default: Console.WriteLine("error");
                    break;
            }
        }
    }
}
