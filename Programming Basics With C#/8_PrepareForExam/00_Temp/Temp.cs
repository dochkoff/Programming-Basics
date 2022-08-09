using System;

namespace _00_Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string stockType = Console.ReadLine();
            int stockCount = int.Parse(Console.ReadLine());

            double stockPrice = 0.0;

            if (country == "Argentina")
            {
                switch (stockType)
                {
                    case "flags":
                        stockPrice = 3.25;
                        break;
                    case "caps":
                        stockPrice = 7.2;
                        break;
                    case "posters":
                        stockPrice = 5.1;
                        break;
                    case "stickers":
                        stockPrice = 1.25;
                        break;
                    default:
                        Console.WriteLine("Invalid stock!");
                        break;
                }
            }
            else if (country == "Brazil")
            {
                switch (stockType)
                {
                    case "flags":
                        stockPrice = 4.2;
                        break;
                    case "caps":
                        stockPrice = 8.5;
                        break;
                    case "posters":
                        stockPrice = 5.35;
                        break;
                    case "stickers":
                        stockPrice = 1.2;
                        break;
                    default:
                        Console.WriteLine("Invalid stock!");
                        break;
                }
            }
            else if (country == "Croatia")
            {
                switch (stockType)
                {
                    case "flags":
                        stockPrice = 2.75;
                        break;
                    case "caps":
                        stockPrice = 6.9;
                        break;
                    case "posters":
                        stockPrice = 4.95;
                        break;
                    case "stickers":
                        stockPrice = 1.1;
                        break;
                    default:
                        Console.WriteLine("Invalid stock!");
                        break;
                }
            }
            else if (country == "Denmark")
            {
                switch (stockType)
                {
                    case "flags":
                        stockPrice = 3.1;
                        break;
                    case "caps":
                        stockPrice = 6.5;
                        break;
                    case "posters":
                        stockPrice = 4.8;
                        break;
                    case "stickers":
                        stockPrice = 0.9;
                        break;
                    default:
                        Console.WriteLine("Invalid stock!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid country");
                return;
            }

            Console.WriteLine($"Pepi bought {stockCount} {stockType} of {country} for {stockCount * stockPrice:F2} lv.");

        }
    }
}

