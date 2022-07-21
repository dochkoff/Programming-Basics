using System;

namespace _04_IntegerInRow
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                int number = int.Parse(command);

                if (number < minNumber)
                {
                    minNumber = number;
                }
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}

