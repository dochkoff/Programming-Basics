using System;

namespace Zad_5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int passengersStart = int.Parse(Console.ReadLine());
            int busStops = int.Parse(Console.ReadLine());

            if (busStops % 2 != 0)
            {
                passengersStart += 2;
            }

            for (int i = 1; i <= busStops; i++)
            {
                int passangersOut = int.Parse(Console.ReadLine());
                int passangersIn = int.Parse(Console.ReadLine());
                passengersStart += passangersIn - passangersOut;
            }

            Console.WriteLine($"The final number of passengers is : {passengersStart}");
        }
    }
}
