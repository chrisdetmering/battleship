using System;

namespace battleship
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Random random = new Random();

            GameBoard gameBoard = new GameBoard();
            Player player = new Player();
            Console.Clear();
            Console.WriteLine("Welcome to C# console Battleship.\n \n");

            for (int i = 0; i < gameBoard.gameBoardArr.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.gameBoardArr.GetLength(1); j++)
                {
                    Console.Write(gameBoard.gameBoardArr[i, j] + " \t");
                }
                Console.WriteLine("\n \n");
            }

            while ((player.shots < player.maxShots) && (player.hits < 3))
            {
                Console.Write("Please enter X coordinate from 1-10: ");
                int guessX = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter Y coordinate from 1-10: ");
                int guessY = Convert.ToInt32(Console.ReadLine());

                if ((guessX < 1 || guessX > 10) || (guessY < 1 || guessY > 10))
                {
                    Console.WriteLine("Guess is outside range. Please select a number from 1-10.");
                }
                else
                {

                    gameBoard.gameBoardArr[guessX - 1, guessY - 1] = " X ";
                    Console.Clear();
                    Console.WriteLine("Welcome to C# console Battleship.\n \n");
                    for (int i = 0; i < gameBoard.gameBoardArr.GetLength(0); i++)
                    {
                        for (int j = 0; j < gameBoard.gameBoardArr.GetLength(1); j++)
                        {
                            Console.Write(gameBoard.gameBoardArr[i, j] + " \t");
                        }
                        Console.WriteLine("\n \n");
                    }
                    player.shots++;
                    Console.WriteLine("Shots remaining: " + (player.maxShots - player.shots));
                }
            }
            //int zeroToNine = random.Next(10);
            //Console.WriteLine(zeroToNine);
        }
    }
}
