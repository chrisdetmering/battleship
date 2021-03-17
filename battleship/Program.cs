using System;

namespace battleship
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            GameBoard gameBoard = new GameBoard();
            Player player = new Player();
            Battleship battleship = new Battleship();
            Console.Clear();
            Console.WriteLine("\t\t\tWelcome to C# console Battleship.\n \n");

            gameBoard.drawGameBoard();

            battleship.RandomShipLoc();

            Console.WriteLine("Shots remaining: " + (player.maxShots - player.shots) + "\n\n");

            while ((player.shots < player.maxShots) && (player.hits < 5))
            {
                Console.Write("Please enter X horizontal coordinate from 1-10: ");
                int guessX = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter Y vertical coordinate from 1-10: ");
                int guessY = Convert.ToInt32(Console.ReadLine());

                if ((guessX < 1 || guessX > 10) || (guessY < 1 || guessY > 10))
                {
                    Console.WriteLine("Guess is outside range. Please select a number from 1-10.");
                }
                else
                {
                    if ((guessX == battleship.location1[0]
                        || guessX == battleship.location2[0]
                        || guessX == battleship.location3[0]
                        || guessX == battleship.location4[0]
                        || guessX == battleship.location5[0])
                        && (guessY == battleship.location1[1]
                        || guessY == battleship.location2[1]
                        || guessY == battleship.location3[1]
                        || guessY == battleship.location4[1]
                        || guessY == battleship.location5[1]))
                    {
                        gameBoard.gameBoardArr[guessY, guessX] = ">X<";
                        player.hits++;
                        player.shots++;
                        Console.Clear();
                        Console.WriteLine("\t\t\t\t\t--> HIT! <--\n\n");
                    }
                    else
                    {
                        gameBoard.gameBoardArr[guessY, guessX] = "> <";
                        player.shots++;
                        Console.Clear();
                        Console.WriteLine("\t\t\t\t\t--> MISS! <--\n\n");
                    }
                    
                    gameBoard.drawGameBoard();

                    Console.WriteLine("Shots remaining: " + (player.maxShots - player.shots) + "\n\n");
                    
                }
            }
            if (player.hits == 5) Console.WriteLine("\t\t\t\tYou sunk my Battleship!!");
            else Console.WriteLine("\t\t\t\tThey got away!");
        }
    }
}
