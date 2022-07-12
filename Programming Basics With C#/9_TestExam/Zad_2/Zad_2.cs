using System;

namespace Zad_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double austronavtsHeight = double.Parse(Console.ReadLine());

            double rocketVolume = x * y * h;
            double roomSpace = 2 * 2 * (austronavtsHeight + 0.4);
            double roomsForAustronavts = Math.Floor(rocketVolume / roomSpace);

            if (roomsForAustronavts > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
            else if (roomsForAustronavts < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else
            {
                Console.WriteLine($"The spacecraft holds {roomsForAustronavts} astronauts.");
            }
        }
    }
}
