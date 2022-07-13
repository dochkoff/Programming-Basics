using System;

namespace FootballSouvenirs
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string teamCountry = Console.ReadLine();
            string souvenir = Console.ReadLine();
            double productCount = int.Parse(Console.ReadLine());

            double souvenirPrice = 0;

            switch (teamCountry)
            {
                case "Argentina":
                    switch (souvenir)
                    {
                        case "flags":
                            souvenirPrice = 3.25;
                            break;
                        case "caps":
                            souvenirPrice = 7.2;
                            break;
                        case "posters":
                            souvenirPrice = 5.1;
                            break;
                        case "stickers":
                            souvenirPrice = 1.25;
                            break;
                        default:
                            Console.WriteLine("Invalid stock!");
                            break;
                    }
                    break;
                case "Brazil":
                    switch (souvenir)
                    {
                        case "flags":
                            souvenirPrice = 4.2;
                            break;
                        case "caps":
                            souvenirPrice = 8.5;
                            break;
                        case "posters":
                            souvenirPrice = 5.35;
                            break;
                        case "stickers":
                            souvenirPrice = 1.2;
                            break;
                        default:
                            Console.WriteLine("Invalid stock!");
                            break;
                    }
                    break;
                case "Croatia":
                    switch (souvenir)
                    {
                        case "flags":
                            souvenirPrice = 2.75;
                            break;
                        case "caps":
                            souvenirPrice = 6.9;
                            break;
                        case "posters":
                            souvenirPrice = 4.95;
                            break;
                        case "stickers":
                            souvenirPrice = 1.1;
                            break;
                        default:
                            Console.WriteLine("Invalid stock!");
                            break;
                    }
                    break;
                case "Denmark":
                    switch (souvenir)
                    {
                        case "flags":
                            souvenirPrice = 3.1;
                            break;
                        case "caps":
                            souvenirPrice = 6.5;
                            break;
                        case "posters":
                            souvenirPrice = 4.8;
                            break;
                        case "stickers":
                            souvenirPrice = 0.9;
                            break;
                        default:
                            Console.WriteLine("Invalid stock!");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid country!");
                    break;
            }

            if (souvenirPrice > 0)
            {
                double sum = souvenirPrice * productCount;
                Console.WriteLine($"Pepi bought {productCount} {souvenir} of {teamCountry} for {sum:F2} lv.");
            }
        }
    }
}
