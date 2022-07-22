﻿using System;

namespace _05_Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSteps = 0;


            while (totalSteps < 10000)
            {
                string command = Console.ReadLine();

                if (command == "Going home")
                {
                    totalSteps += int.Parse(Console.ReadLine());
                    break;
                }
                totalSteps += int.Parse(command);
            }

            if (totalSteps >= 10000)
            {
                Console.WriteLine($"Goal reached! Good job!");
            }
            else
            {
                Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
            }
        }
    }
}

