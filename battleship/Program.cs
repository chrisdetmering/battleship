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

            display.TitleScreen();

            var startGame = Console.ReadKey(true).KeyChar;
            var isBattleshipSunk = true;

            if (startGame == ' ')
            {
                isBattleshipSunk = false;

                Console.Clear();
                Console.WriteLine("\n\n");

                display.GameBoard();

                Console.WriteLine($"Shots remaining: {Player.MAX_SHOTS - player.Shots}\n\nBattleship lives remaining: {battleship.Lives}\n");

                battleship.RandomShipLocation();
            }

            while (!isBattleshipSunk)
            {
                Console.Write("Please enter X horizontal coordinate from 1-10: ");

                if (int.TryParse(Console.ReadLine(), out int valueX))
                    player.guessX = valueX;

                Console.Write("\nPlease enter Y vertical coordinate from 1-10: ");

                if (int.TryParse(Console.ReadLine(), out int valueY))
                    player.guessY = valueY;

                var isInvalidGuess =
                    ((player.guessX < 1 || player.guessX > 10)
                    || (player.guessY < 1 || player.guessY > 10))
                    || (display.gameBoard[player.guessY, player.guessX] == ">X<")
                    || (display.gameBoard[player.guessY, player.guessX] == "> <");

                if (isInvalidGuess)
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
                    var isTargetHit =
                      ((player.guessX == battleship.location1[0]
                        || player.guessX == battleship.location2[0]
                        || player.guessX == battleship.location3[0]
                        || player.guessX == battleship.location4[0]
                        || player.guessX == battleship.location5[0])
                        && (player.guessY == battleship.location1[1]
                        || player.guessY == battleship.location2[1]
                        || player.guessY == battleship.location3[1]
                        || player.guessY == battleship.location4[1]
                        || player.guessY == battleship.location5[1]));

                    if (isTargetHit)
                    {
                        display.gameBoard[player.guessY, player.guessX] = ">X<";
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
                        display.gameBoard[player.guessY, player.guessX] = "> <";
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

                        isBattleshipSunk = true;
                    }

                    if (Player.MAX_SHOTS - player.Shots < battleship.Lives)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\t\t<<<<===   Not enough shots left! They got away!  ====>>>>\n");
                        Console.ResetColor();

                        isBattleshipSunk = true;
                    }
                }

                if (isBattleshipSunk)
                {
                    Console.Write("\n\n\t\t\t\t     Play again Y?\n\n\t\t\t\tAny other key to exit.");
                    var input = Char.ToUpper(Console.ReadKey(true).KeyChar);
                    if (input == 'Y')
                    {
                        Console.Clear();

                        isBattleshipSunk = false;
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
            Console.WriteLine("\n\n\n\n\n\t\t~~+`'._.'`+~~ Thanks for playing, goodbye ~~+`'._.'`+~~");
        }
    }
}
