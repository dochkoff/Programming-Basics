using System;

namespace ExamPreparation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int badScores = int.Parse(Console.ReadLine());
            string problemName = Console.ReadLine();
            int problemSocre = int.Parse(Console.ReadLine());

            int counter = 0;
            int badScore = 0;
            int totalScore = 0;

            while (problemName != "Enough")
            {
                if (problemSocre <= 4)
                {
                    badScore++;
                    totalScore += problemSocre;
                }
                else
                {
                    totalScore += problemSocre;
                }

                counter++;

                if (badScore == badScores)
                {
                    Console.WriteLine($"You need a break, {badScores} poor grades.");
                    break;
                }

                string input = Console.ReadLine();

                if (input == "Enough")
                {
                    Console.WriteLine($"Average score: {(totalScore * 1.0 / counter):F2}");
                    Console.WriteLine($"Number of problems: {counter}");
                    Console.WriteLine($"Last problem: {problemName}");
                    break;
                }
                problemName = input;
                problemSocre = int.Parse(Console.ReadLine());
            }
        }
    }
}
