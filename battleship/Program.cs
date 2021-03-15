using System;

namespace battleship
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            GameBoard gameBoard = new GameBoard();
            Console.Clear();
            Console.WriteLine("Welcome to C# console Battleship.\n \n");
            gameBoard.gameBoardArr[1, 1] = " X";

            for(int i = 0; i < gameBoard.gameBoardArr.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.gameBoardArr.GetLength(1); j++)
                {
                    Console.Write(gameBoard.gameBoardArr[i, j] + " \t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
