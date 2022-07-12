using System;

namespace Volleyball
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            double p = int.Parse(Console.ReadLine()); //holidays
            double h = int.Parse(Console.ReadLine()); //times going home

            if (year == "normal")
            {
                double gamesInSofia = (48 - h) * 3 / 4 + p * 2 / 3;
                double allGames = Math.Floor(gamesInSofia + h);
                Console.WriteLine(allGames);
            }
            else if (year == "leap")
            {
                double gamesInSofia = (48 - h) * 3 / 4 + p * 2 / 3;
                double allGames = Math.Floor((gamesInSofia + h) * 1.15);
                Console.WriteLine(allGames);
            }
        }
    }
}
