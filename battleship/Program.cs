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
            Console.WriteLine("\t\t\t\tWelcome to C# console Battleship.\n\n");

            gameBoard.drawGameBoard();

            battleship.RandomShipLocation();

            Console.WriteLine("Shots remaining: " + (player.maxShots - player.shots) + "\n\n");

            Console.WriteLine("\nTo start press spacebar");
            var startGame = Console.ReadKey(true).KeyChar;
            var gameover = true;
            if (startGame == ' ') gameover = false;

            while (!gameover)
            {

                Console.Write("Please enter X horizontal coordinate from 1-10: ");

                if (int.TryParse(Console.ReadLine(), out int valueX))
                    player.guessX = valueX;


                Console.Write("\nPlease enter Y vertical coordinate from 1-10: ");

                if (int.TryParse(Console.ReadLine(), out int valueY))
                    player.guessY = valueY;

                if ((player.guessX < 1 || player.guessX > 10) || (player.guessY < 1 || player.guessY > 10))
                {
                    Console.WriteLine("Not a valid shot. Please select a number from 1-10.");
                }
                else
                {
                    if ((player.guessX == battleship.location1[0]
                        || player.guessX == battleship.location2[0]
                        || player.guessX == battleship.location3[0]
                        || player.guessX == battleship.location4[0]
                        || player.guessX == battleship.location5[0])
                        && (player.guessY == battleship.location1[1]
                        || player.guessY == battleship.location2[1]
                        || player.guessY == battleship.location3[1]
                        || player.guessY == battleship.location4[1]
                        || player.guessY == battleship.location5[1]))
                    {
                        gameBoard.gameBoardArr[player.guessY, player.guessX] = ">X<";
                        player.hits++;
                        player.shots++;
                        Console.Clear();
                        Console.WriteLine("\t\t\t\t\t--> HIT! <--\n\n");
                    }
                    else
                    {
                        gameBoard.gameBoardArr[player.guessY, player.guessX] = "> <";
                        player.shots++;
                        Console.Clear();
                        Console.WriteLine("\t\t\t\t\t--> MISS! <--\n\n");
                    }

                    gameBoard.drawGameBoard();

                    Console.WriteLine("Shots remaining: " + (player.maxShots - player.shots) + "\n\n");

                    if (player.hits == 5)
                    {
                        Console.WriteLine("\t\t\t\tYou sunk my Battleship!!");
                        gameover = true;
                    }
                    if (player.shots == 10)
                    {
                        Console.WriteLine("\t\t\t\t\tThey got away!");
                        gameover = true;
                    }

                }
                if (gameover)
                {
                    Console.WriteLine("Play again?");
                    var input = Console.ReadKey(true).KeyChar;
                    if (input == 'y' || input == 'Y')
                    {
                        player.shots = 0;
                        player.hits = 0;
                        gameover = false;
                        Console.Clear();

                        gameBoard.drawGameBoard();

                        Console.WriteLine("Shots remaining: " + (player.maxShots - player.shots) + "\n\n");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Thanks for playing, goodbye.");
                    }
                }
            }
        }
        
    }
}
