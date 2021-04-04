using System;

namespace battleship
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            var display = new Display();
            var player = new Player();
            var battleship = new Battleship();

            display.TitleStart();

            if (Console.ReadKey(true).KeyChar == ' ')
            {
                battleship.SetIsBattleshipSunk();

                display.BattleShipSunk(player, battleship);
 ;
                battleship.RandomShipLocation();
            }

            while (!battleship.IsBattleshipSunk)
            {
                player.ReadGuess();

                if (!player.IsValidGuess(display.gameBoard))
                {

                    display.NotValidGuess(player, battleship); 

                }
                else
                {
                    if (battleship.IsTargetHit(player.GuessX, player.GuessY))
                    {
                        display.UpdateGameBoard(player.GuessX, player.GuessY, ">X<");
                        battleship.TakeHit();
                        player.HitCount();
                        player.Shoot();
                        display.Hit(); 
                    }
                    else
                    {
                        display.UpdateGameBoard(player.GuessX, player.GuessY, "> <");
                        player.Shoot();
                        display.Miss();
                    }

                    display.GameBoard();
                    display.ScoreBoard(player, battleship);

                    if (player.Hits == 5)
                    {
                        display.BattleShipSunk();
                        battleship.SetIsBattleshipSunk();
                    }

                    if (Player.MAX_SHOTS - player.Shots < battleship.Lives)
                    {
                        display.NotEnoughShots();
                        battleship.SetIsBattleshipSunk();
                    }
                }

                if (battleship.IsBattleshipSunk)
                {
                    display.PlayAgain();
                    var input = Char.ToUpper(Console.ReadKey(true).KeyChar);
                    if (input == 'Y')
                    {
                        Console.Clear();
                        battleship.SetIsBattleshipSunk(); 
                        display.ResetGameBoard();
                        player.ResetPlayer();
                        battleship.ResetLives();
                        battleship.RandomShipLocation();
                        Console.WriteLine("\n\n");
                        display.GameBoard();
                        display.ScoreBoard(player, battleship);

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
