using System;

namespace EnergyBooster
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string fruitType = Console.ReadLine();
            string setType = Console.ReadLine();
            int sets = int.Parse(Console.ReadLine());

            double setPrice = 0;

            switch (setType)
            {
                case "small":
                    switch (fruitType)
                    {
                        case "Watermelon":
                            setPrice = 2 * 56;
                            break;
                        case "Mango":
                            setPrice = 2 * 36.66;
                            break;
                        case "Pineapple":
                            setPrice = 2 * 42.1;
                            break;
                        case "Raspberry":
                            setPrice = 2 * 20;
                            break;
                    }
                    break;
                case "big":
                    switch (fruitType)
                    {
                        case "Watermelon":
                            setPrice = 5 * 28.7;
                            break;
                        case "Mango":
                            setPrice = 5 * 19.6;
                            break;
                        case "Pineapple":
                            setPrice = 5 * 24.8;
                            break;
                        case "Raspberry":
                            setPrice = 5 * 15.2;
                            break;
                    }
                    break;
            }

            double allSetsPrice = sets * setPrice;

            if (allSetsPrice >= 400 && allSetsPrice <= 1000)
            {
                allSetsPrice = allSetsPrice - (allSetsPrice * 0.15);
            }
            else if (allSetsPrice > 1000)
            {
                allSetsPrice = allSetsPrice * 0.5;
            }

            Console.WriteLine($"{allSetsPrice:F2} lv.");
        }
    }
}
