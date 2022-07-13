using System;

namespace TicketCombination
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int count = 0;
            int bonus = 0;

            for (int x1 = 'B'; x1 <= 'L'; x1 += 2)
            {
                for (int x2 = 'f'; x2 >= 'a'; x2--)
                {
                    for (int x3 = 'A'; x3 <= 'C'; x3++)
                    {
                        for (int x4 = 1; x4 <= 10; x4++)
                        {
                            for (int x5 = 10; x5 >= 1; x5--)
                            {
                                count++;
                                if (count == number)
                                {
                                    bonus = x1 + x2 + x3 + x4 + x5;
                                    Console.WriteLine($"Ticket combination: {(char)x1}{(char)x2}{(char)x3}{x4}{x5}");
                                    Console.WriteLine($"Prize: {bonus} lv.");
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
