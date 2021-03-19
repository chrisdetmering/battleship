using System;

namespace battleship
{
    class GameBoard
    {
        public string[,] gameBoardArr = new string[11, 11]
        {
            { " # ", " 1.", " 2.", " 3.", " 4.", " 5.", " 6.", " 7.", " 8.", " 9.", " 10." },
            { " 1.", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O " },
            { " 2.", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O " },
            { " 3.", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O " },
            { " 4.", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O " },
            { " 5.", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O " },
            { " 6.", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O " },
            { " 7.", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O " },
            { " 8.", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O " },
            { " 9.", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O " },
            { "10.", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O ", " O " },
        };

        public void drawGameBoard()
        {
            for (int i = 0; i < gameBoardArr.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoardArr.GetLength(1); j++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(gameBoardArr[i, j] + " \t");
                    Console.ResetColor();
                }
                Console.WriteLine("\n \n");
            }
        }
    }
}
