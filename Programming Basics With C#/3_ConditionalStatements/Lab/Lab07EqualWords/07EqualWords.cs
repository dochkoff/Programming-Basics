using System;

namespace Lab07EqualWords
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string word1 = Console.ReadLine().ToLower(); //pravi vsichki bukvi malki
            string word2 = Console.ReadLine().ToLower();

            if (word1 == word2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
