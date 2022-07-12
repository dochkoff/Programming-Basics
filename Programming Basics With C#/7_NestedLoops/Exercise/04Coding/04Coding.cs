using System;

namespace Coding
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n.ToString().Length; i++)
            {
                int count = n % 10;
                n = n / 10;

                if (count == 0)
                {
                    Console.WriteLine("ZERO");
                    continue;
                }
                for (int x1 = 1; x1 <= count; x1++)
                {
                    char symbol = Convert.ToChar(count + 33);
                    Console.Write(symbol);
                }
            }
            Console.WriteLine();

            //string input = Console.ReadLine();

            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    string empty = string.Empty;
            //    string charToString = empty + input[i];
            //    int num = int.Parse(charToString);

            //    if (num == 0)
            //    {
            //        Console.WriteLine("ZERO");
            //        continue;
            //    }

            //    for (int m = 0; m < num; m++)
            //    {
            //        Console.Write((char)(num + 33));
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
