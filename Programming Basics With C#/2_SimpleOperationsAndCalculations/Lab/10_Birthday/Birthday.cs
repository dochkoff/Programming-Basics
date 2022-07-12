using System;

namespace Birthday
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volume = lenght * width * height; //izchislqvame obema v cm3
            double liters = volume * 0.001; // obema v litri
            double newPercent = percent * 0.01;

            double needLiters = liters * (1 - newPercent);

            Console.WriteLine($"{needLiters:F3}");
        }
    }
}
