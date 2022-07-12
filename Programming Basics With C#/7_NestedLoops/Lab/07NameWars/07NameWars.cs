using System;

namespace NameWars
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int max = int.MinValue;
            string maxName = string.Empty;
            int sumLetters = 0;

            while (name != "STOP")
            {
                for (int i = 0; i < name.Length; i++) //vzimame duljinata na stringa
                {
                    char currentSymbol = name[i]; //vzimame ASKII stoinosta na poziciqta v stringa
                    sumLetters += currentSymbol; //sumirame sbora ot vsichki simvoli
                }

                if (sumLetters > max)
                {
                    max = sumLetters;
                    maxName = name;
                }
                name = Console.ReadLine();
                sumLetters = 0;
            }

            Console.WriteLine($"Winner is {maxName} - {max}!");
        }
    }
}
