using System;

namespace Zad_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string sushiType = Console.ReadLine();
            string restourantName = Console.ReadLine();
            int portions = int.Parse(Console.ReadLine());
            char orderType = char.Parse(Console.ReadLine());

            double price = 0;
            double totalPrice = 0;

            switch (sushiType)
            {
                case "sashimi":
                    switch (restourantName)
                    {
                        case "Sushi Zone":
                            price += 4.99;
                            break;
                        case "Sushi Time":
                            price += 5.49;
                            break;
                        case "Sushi Bar":
                            price += 5.25;
                            break;
                        case "Asian Pub":
                            price += 4.5;
                            break;
                        default:
                            Console.WriteLine($"{restourantName} is invalid restaurant!");
                            return;
                    }
                    break;
                case "maki":
                    switch (restourantName)
                    {
                        case "Sushi Zone":
                            price += 5.29;
                            break;
                        case "Sushi Time":
                            price += 4.69;
                            break;
                        case "Sushi Bar":
                            price += 5.55;
                            break;
                        case "Asian Pub":
                            price += 4.80;
                            break;
                        default:
                            Console.WriteLine($"{restourantName} is invalid restaurant!");
                            return;
                    }
                    break;
                case "uramaki":
                    switch (restourantName)
                    {
                        case "Sushi Zone":
                            price += 5.99;
                            break;
                        case "Sushi Time":
                            price += 4.49;
                            break;
                        case "Sushi Bar":
                            price += 6.25;
                            break;
                        case "Asian Pub":
                            price += 5.50;
                            break;
                        default:
                            Console.WriteLine($"{restourantName} is invalid restaurant!");
                            return;
                    }
                    break;
                case "temaki":
                    switch (restourantName)
                    {
                        case "Sushi Zone":
                            price += 4.29;
                            break;
                        case "Sushi Time":
                            price += 5.19;
                            break;
                        case "Sushi Bar":
                            price += 4.75;
                            break;
                        case "Asian Pub":
                            price += 5.50;
                            break;
                        default:
                            Console.WriteLine($"{restourantName} is invalid restaurant!");
                            return;
                    }
                    break;
            }

            if (orderType == 'Y')
            {
                totalPrice = Math.Ceiling((portions * price) * 1.2);
                Console.WriteLine($"Total price: {totalPrice} lv.");
            }
            else if (orderType == 'N')
            {
                totalPrice = Math.Ceiling(portions * price);
                Console.WriteLine($"Total price: {totalPrice} lv.");
            }
        }
    }
}
