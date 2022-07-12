using System;

namespace TrainTheTrainers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string presentationName = Console.ReadLine();
            int presentationCount = 0;
            double allPresentationGrades = 0;

            while (presentationName != "Finish")
            {
                presentationCount++;
                double sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sum += grade;
                }
                double currentaverage = sum / n;
                allPresentationGrades += currentaverage;
                Console.WriteLine($"{presentationName} - {currentaverage:F2}.");
                presentationName = Console.ReadLine();
            }
            double finalAverage = allPresentationGrades / presentationCount;
            Console.WriteLine($"Student's final assessment is {finalAverage:F2}.");
        }
    }
}
