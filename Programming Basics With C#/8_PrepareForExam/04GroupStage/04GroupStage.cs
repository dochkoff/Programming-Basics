using System;

namespace GroupStage
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int gamemsCount = int.Parse(Console.ReadLine());

            int makeGoals = 0;
            int inGoals = 0;
            int makeGoalsSum = 0;
            int inGoalsSum = 0;
            int points = 0;

            for (int i = 0; i < gamemsCount; i++)
            {
                makeGoals = int.Parse(Console.ReadLine());
                inGoals = int.Parse(Console.ReadLine());
                makeGoalsSum += makeGoals;
                inGoalsSum += inGoals;

                if (makeGoals - inGoals > 0)
                {
                    points += 3;
                }
                else if (makeGoals - inGoals == 0)
                {
                    points += 1;
                }
            }

            if (makeGoalsSum >= inGoalsSum)
            {
                Console.WriteLine($"{teamName} has finished the group phase with {points} points.");
                Console.WriteLine($"Goal difference: {makeGoalsSum - inGoalsSum}.");
            }
            else
            {
                Console.WriteLine($"{teamName} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {makeGoalsSum - inGoalsSum}.");
            }

        }
    }
}
