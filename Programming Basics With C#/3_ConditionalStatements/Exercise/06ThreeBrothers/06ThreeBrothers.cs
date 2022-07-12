using System;

namespace ThreeBrothers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double timeA = double.Parse(Console.ReadLine());
            double timeB = double.Parse(Console.ReadLine());
            double timeC = double.Parse(Console.ReadLine());
            double timeD = double.Parse(Console.ReadLine());

            double cleaningTime = 1 / (1 / timeA + 1 / timeB + 1 / timeC);
            double allTime = cleaningTime * 1.15;
            double leftTime = timeD - allTime;

            if (leftTime >= 0)
            {
                Console.WriteLine($"Cleaning time: {allTime:F2}");
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(leftTime)} hours.");
            }
            else
            {
                Console.WriteLine($"Cleaning time: {allTime:F2}");
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(Math.Abs(leftTime))} hours.");
            }
        }
    }
}
