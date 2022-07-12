using System;

namespace Cinema
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int colum = int.Parse(Console.ReadLine());

            if (projectionType == "Premiere")
            {
                Console.WriteLine($"{12.0 * row * colum:F2} leva");
            }
            else if (projectionType == "Normal")
            {
                Console.WriteLine($"{7.5 * row * colum:F2} leva");
            }
            else if (projectionType == "Discount")
            {
                Console.WriteLine($"{5.0 * row * colum:F2} leva");
            }
        }
    }
}
