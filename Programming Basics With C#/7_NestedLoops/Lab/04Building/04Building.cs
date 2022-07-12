using System;

namespace Building
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int countRooms = int.Parse(Console.ReadLine());

            for (int currrentFloor = floors; currrentFloor >= 1; currrentFloor--)
            {
                for (int currentRoom = 0; currentRoom < countRooms; currentRoom++)
                {
                    if (currrentFloor == floors)
                    {
                        Console.Write($"L{currrentFloor}{currentRoom} ");
                        continue;
                    }

                    if (currrentFloor % 2 == 1)
                    {
                        Console.Write($"A{currrentFloor}{currentRoom} ");
                    }
                    else
                    {
                        Console.Write($"O{currrentFloor}{currentRoom} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
