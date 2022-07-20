using System;

namespace _02_Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double counter = 1;
            double sum = 0;

            while (counter <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 4)
                {
                    sum += grade;
                    counter++;
                }
            }

            Console.WriteLine($"{name} graduated. Average grade: {sum / 12:F2}");
        }
    }
}

