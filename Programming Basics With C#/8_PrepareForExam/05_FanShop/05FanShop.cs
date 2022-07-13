using System;

namespace FanShop
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                string productName = Console.ReadLine();

                switch (productName)
                {
                    case "hoodie":
                        sum += 30;
                        break;
                    case "keychain":
                        sum += 4;
                        break;
                    case "T-shirt":
                        sum += 20;
                        break;
                    case "flag":
                        sum += 15;
                        break;
                    case "sticker":
                        sum += 1;
                        break;
                }
            }

            if (budget >= sum)
            {
                Console.WriteLine($"You bought {n} items and left with {budget - sum} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {sum - budget} more lv.");
            }
        }
    }
}
