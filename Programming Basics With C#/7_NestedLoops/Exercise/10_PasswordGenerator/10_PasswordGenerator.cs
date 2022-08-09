using System;

namespace _10_PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int x1 = 1; x1 <= n; x1++)
            {
                for (int x2 = 1; x2 <= n; x2++)
                {
                    for (char x3 = (char)97; x3 <= l + 96; x3++)
                    {
                        for (char x4 = (char)97; x4 <= l + 96; x4++)
                        {
                            for (int x5 = 1; x5 <= n; x5++)
                            {
                                if (x5 > x1 && x5 > x2)
                                {
                                    Console.Write($"{x1}{x2}{x3}{x4}{x5} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

