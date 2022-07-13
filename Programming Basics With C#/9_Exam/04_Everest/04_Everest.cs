using System;

namespace Everest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int startHeight = 5364;
            int days = 1;
            int dayHeight = 0;

            while (startHeight < 8848)
            {
                string sleep = Console.ReadLine();

                if (sleep == "END")
                {
                    Console.WriteLine("Failed!");
                    Console.WriteLine(startHeight);
                    break;
                }

                if (sleep == "Yes")
                {
                    days++;
                }

                if (days > 5 && startHeight != 8848)
                {
                    Console.WriteLine("Failed!");
                    Console.WriteLine(startHeight);
                    break;
                }

                dayHeight = int.Parse(Console.ReadLine());
                startHeight += dayHeight;


            }

            if (startHeight >= 8848)
            {
                Console.WriteLine($"Goal reached for {days} days!");
            }
        }
    }
}
