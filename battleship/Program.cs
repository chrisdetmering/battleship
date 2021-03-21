using System;

namespace battleship
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Display display = new Display();
            Player player = new Player();
            Battleship battleship = new Battleship();

            display.TitleStart();

            if (Console.ReadKey(true).KeyChar == ' ')
            {
                battleship.IsBattleshipSunk = false;
                Console.Clear();
                Console.WriteLine("\n\n");
                display.GameBoard();
                Console.WriteLine($"Shots remaining: {Player.MAX_SHOTS - player.Shots}\n\nBattleship lives remaining: {battleship.Lives}\n");
                battleship.RandomShipLocation();
            }

            while (!battleship.IsBattleshipSunk)
            {
                player.ReadGuess();

                if (!player.IsValidGuess(display.gameBoard))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t~ That was not a valid target ~ Please select a number from 1-10.\n\n");
                    Console.ResetColor();
                    display.GameBoard();
                    Console.WriteLine($"Shots remaining: {Player.MAX_SHOTS - player.Shots}\n\nBattleship lives remaining: {battleship.Lives}\n");
                }
                else
                {
                    if (battleship.IsTargetHit(player.GuessX, player.GuessY))
                    {
                        display.UpdateGameBoard(player.GuessX, player.GuessY, ">X<");
                        battleship.TakeHit();
                        player.HitCount();
                        player.Shoot();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\t\t\t\t   --> HIT! <--\n\n");
                        Console.ResetColor();
                    }
                    else
                    {
                        display.UpdateGameBoard(player.GuessX, player.GuessY, "> <");
                        player.Shoot();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\t\t\t\t   <-- MISS! -->\n\n");
                        Console.ResetColor();
                    }

                    display.GameBoard();
                    Console.WriteLine($"Shots remaining: {Player.MAX_SHOTS - player.Shots}\n\nBattleship lives remaining: {battleship.Lives}\n");

                    if (player.Hits == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\t\t\t====>>>>    BATTLESHIP SUNK!   <<<<=====\n");
                        Console.ResetColor();
                        battleship.IsBattleshipSunk = true;
                    }

                    if (Player.MAX_SHOTS - player.Shots < battleship.Lives)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\t\t<<<<===   Not enough shots left! They got away!  ====>>>>\n");
                        Console.ResetColor();
                        battleship.IsBattleshipSunk = true;
                    }
                }

                if (battleship.IsBattleshipSunk)
                {
                    Console.Write("\n\n\t\t\t\t     Play again Y?\n\n\t\t\t\tAny other key to exit.");
                    var input = Char.ToUpper(Console.ReadKey(true).KeyChar);
                    if (input == 'Y')
                    {
                        Console.Clear();
                        battleship.IsBattleshipSunk = false;
                        display.ResetGameBoard();
                        player.ResetPlayer();
                        battleship.ResetLives();
                        battleship.RandomShipLocation();
                        Console.WriteLine("\n\n");
                        display.GameBoard();
                        Console.WriteLine($"Shots remaining: {Player.MAX_SHOTS - player.Shots}\n\nBattleship lives remaining: {battleship.Lives}\n");

                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.Clear();
            display.TitleEnd();
        }
    }
}
