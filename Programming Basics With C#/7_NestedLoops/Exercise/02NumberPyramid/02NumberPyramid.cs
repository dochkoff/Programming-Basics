using System;

namespace NumberPyramid
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int r = 1; r <= i; r++)
                {
                    counter++;
                    Console.Write(counter + " ");

                    if (counter == n)
                    {
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
