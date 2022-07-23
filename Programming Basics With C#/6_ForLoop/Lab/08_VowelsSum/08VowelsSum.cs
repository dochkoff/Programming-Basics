using System;

namespace VowelsSum
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int inputWordLenght = word.Length;

            int sum = 0;

            for (int i = 0; i < inputWordLenght; i++)
            {
                char currentLetter = word[i];

                switch (currentLetter)
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
