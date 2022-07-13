using System;

namespace WorldSwimmingRecord
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double recordTime = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForMeter = double.Parse(Console.ReadLine());

            double timeForSwimming = distance * timeForMeter;
            double resistance = Math.Floor(distance / 15) * 12.5;
            double fullTime = timeForSwimming + resistance;

            if (fullTime < recordTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {fullTime:F2} seconds.");
            }
            else
            {
                double difference = fullTime - recordTime;
                Console.WriteLine($"No, he failed! He was {difference:F2} seconds slower.");
            }
        }
    }
}
