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
            double badGrade = 0;

            while (counter <= 12 && badGrade <= 1)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 4)
                {
                    sum += grade;
                    counter++;
                }
                else
                {
                    badGrade++;
                }
            }

            if (badGrade <= 1)
            {
                Console.WriteLine($"{name} graduated. Average grade: {sum / 12:F2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {counter} grade");
            }
        }
    }
}

