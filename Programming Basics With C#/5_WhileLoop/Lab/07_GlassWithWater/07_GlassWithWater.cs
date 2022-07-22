using System;

namespace _07_GlassWithWater
{
    class Program
    {
        static void Main(string[] args)
        {
            double glassVolume = double.Parse(Console.ReadLine());
            double glassFill = 0.0;
            int counter = 0;

            while (glassFill < glassVolume)
            {
                string button = Console.ReadLine();

                if (button == "Easy")
                {
                    glassFill += 50;
                }
                else if (button == "Medium")
                {
                    glassFill += 100;
                }
                else if (button == "Hard")
                {
                    glassFill += 200;
                }
                counter++;
            }

            if (glassFill == glassVolume)
            {
                Console.WriteLine($"The dispenser has been tapped {counter} times.");
            }
            else
            {
                Console.WriteLine($"{glassFill - glassVolume}ml has been spilled.");
            }
        }
    }
}

