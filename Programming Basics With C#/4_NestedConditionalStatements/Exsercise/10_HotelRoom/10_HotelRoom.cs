using System;

namespace _10_HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double priceStudio = 0.0;
            double priceApartment = 0.0;

            if (mounth == "May" || mounth == "October")
            {
                priceStudio = 50;
                priceApartment = 65;

                if (nights > 7 && nights <= 14)
                {
                    priceStudio *= 0.95;
                }
                else if (nights > 14)
                {
                    priceStudio *= 0.7;
                    priceApartment *= 0.9;
                }
            }
            else if (mounth == "June" || mounth == "September")
            {
                priceStudio = 75.20;
                priceApartment = 68.70;

                if (nights > 14)
                {
                    priceStudio *= 0.8;
                    priceApartment *= 0.9;
                }
            }
            else if (mounth == "July" || mounth == "August")
            {
                priceStudio = 76;
                priceApartment = 77;

                if (nights > 14)
                {
                    priceApartment *= 0.9;
                }
            }

            Console.WriteLine($"Apartment: {(priceApartment * nights):F2} lv.");
            Console.WriteLine($"Studio: {(priceStudio * nights):F2} lv.");

        }
    }
}

