using System;

namespace Cake
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int cakeSize = width * lenght;

            string command = Console.ReadLine();

            while (command != "STOP")
            {
                int pieces = int.Parse(command);
                cakeSize = cakeSize - pieces;

                if (cakeSize < 0)
                {
                    break;
                }
                command = Console.ReadLine();
            }

            if (cakeSize < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{cakeSize} pieces are left.");
            }
        }
    }
}
