using System;

namespace Exercise05DanceHall
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());

            double w = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());

            double hallArea = (l * 100) * (w * 100);
            double wardrobeArea = (a * a * 10000);
            double benchArea = hallArea / 10;
            double freeSpace = hallArea - wardrobeArea - benchArea;
            double dancers = freeSpace / (40 + 7000);

            Console.WriteLine(Math.Floor(dancers));
        }
    }
}
