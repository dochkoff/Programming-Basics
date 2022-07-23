using System;

namespace _09_Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int quarterVolume = width * lenght * height;
            int movedVolume = 0;

            while (quarterVolume >= movedVolume)
            {
                string command = Console.ReadLine();

                if (command == "Done")
                {
                    break;
                }

                int cartons = int.Parse(command);
                movedVolume += cartons;
            }

            if (quarterVolume >= movedVolume)
            {
                Console.WriteLine($"{quarterVolume - movedVolume} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {movedVolume - quarterVolume} Cubic meters more.");
            }
        }
    }
}

