using System;

namespace _PersonalTitles
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char gander = Console.ReadLine()[0]; //Vzima purvata bukva ot string

            if (gander == 'f')
            {
                if (age < 16)
                {
                    Console.WriteLine("Miss");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }
            else if (gander == 'm')
            {
                if (age < 16)
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Mr.");
                }
            }
        }
    }
}
