using System;

namespace FootballSouvenirs
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int playedGames = int.Parse(Console.ReadLine());

            int totalTeamScore = 0;
            int totalOponentScore = 0;
            int teamPoints = 0;

            for (int i = 0; i < playedGames; i++)
            {
                int teamScore = int.Parse(Console.ReadLine());
                int oponentScore = int.Parse(Console.ReadLine());

                totalTeamScore += teamScore;
                totalOponentScore += oponentScore;

                if (teamScore > oponentScore)
                {
                    teamPoints += 3;
                }
                else if (teamScore == oponentScore)
                {
                    teamPoints += 1;
                }
            }

            if (totalTeamScore >= totalOponentScore)
            {
                Console.WriteLine($"{teamName} has finished the group phase with {teamPoints} points.");
                Console.WriteLine($"Goal difference: {totalTeamScore - totalOponentScore}.");
            }
            else
            {
                Console.WriteLine($"{teamName} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {totalOponentScore - totalTeamScore}.");
            }
        }
    }
}