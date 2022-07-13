using System;

namespace SchoolTrip
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int daysOut = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double dayFoodDog1 = double.Parse(Console.ReadLine());
            double dayFoodDog2 = double.Parse(Console.ReadLine());
            double dayFoodDog3 = double.Parse(Console.ReadLine());

            double foodForAllDaysAndDogs = daysOut * (dayFoodDog1 + dayFoodDog2 + dayFoodDog3);

            if (foodForAllDaysAndDogs > foodLeft)
            {
                Console.WriteLine($"{Math.Ceiling(foodForAllDaysAndDogs - foodLeft)} more kilos of food are needed.");
            }
            else
            {
                Console.WriteLine($"{Math.Floor(foodLeft - foodForAllDaysAndDogs)} kilos of food left.");
            }
        }
    }
}
