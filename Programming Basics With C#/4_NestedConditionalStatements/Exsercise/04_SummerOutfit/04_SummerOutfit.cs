using System;

namespace SummerOutfit
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string dayTame = Console.ReadLine();

            string outfit = "n/a";
            string shoes = "n/a";

            if (degrees >= 10 && degrees <= 18)
            {
                if (dayTame == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (dayTame == "Afternoon")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (dayTame == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (degrees > 18 && degrees <= 24)
            {
                if (dayTame == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (dayTame == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (dayTame == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (degrees >= 25)
            {
                if (dayTame == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals"; ;
                }
                else if (dayTame == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (dayTame == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
