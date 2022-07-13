using System;

namespace Scholarship
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double steps = double.Parse(Console.ReadLine());
            double dancers = double.Parse(Console.ReadLine());
            double daysForLearn = double.Parse(Console.ReadLine());

            double stepsPerDay = ((steps / daysForLearn) / steps)*100; //v procenti
            double stepsPerDancer = Math.Ceiling(stepsPerDay) / dancers; //v %

            if (stepsPerDay <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {stepsPerDancer:F2}%.");
            }
            else
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {stepsPerDancer:F2}% steps to be learned per day.");
            }
        }
    }
}
