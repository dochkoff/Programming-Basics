using System;

namespace OldBooks
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int booksInLybrary = int.Parse(Console.ReadLine());

            int counter = 0;

            while (counter <= booksInLybrary)
            {
                string bookNames = Console.ReadLine();

                if (bookName == bookNames)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }

                if (counter == booksInLybrary)
                {
                    Console.WriteLine($"The book you search is not here!");
                    Console.WriteLine($"You checked {booksInLybrary} books.");
                    break;
                }

                counter++;
            }
        }
    }
}
