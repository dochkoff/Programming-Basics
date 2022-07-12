using System;

namespace NumberInRange1_100
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int weight = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());


            int space = weight * lenght * height;
            int boxesSum = 0;
            bool neededSpace = true;

            while (space - boxesSum >= 0)
            {
                string command = Console.ReadLine();
                if (command == "Done")
                {
                    neededSpace = false;
                    break;
                }

                int boxes = int.Parse(command);
                boxesSum += boxes;
            }

            if (neededSpace == false)
            {
                Console.WriteLine($"{space - boxesSum} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(space - boxesSum)} Cubic meters more.");
            }
        }
    }
}
