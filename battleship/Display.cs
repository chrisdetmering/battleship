using System;

namespace battleship
{
    class Display
    {
        public string[,] gameBoard = new string[11, 11]
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

        public void GameBoard()
        {
            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {
                    if (gameBoard[i, j] == "> <")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(gameBoard[i, j] + " \t");
                        Console.ResetColor();
                    }
                    else if (gameBoard[i, j] == ">X<")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(gameBoard[i, j] + " \t");
                        Console.ResetColor();
                    }
                    else if (gameBoard[i, j] == " O ")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write(gameBoard[i, j] + " \t");
                        Console.ResetColor();
                    }
                    else 
                    Console.Write(gameBoard[i, j] + " \t");
                }
                Console.WriteLine("\n \n");
            }
        }

        public void UpdateGameBoard(int guessX, int guessY, string icon)
        {
            gameBoard[guessY, guessX] = icon;
        }

        public void ResetGameBoard()
        {
            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {
                    if (gameBoard[i, j] == ">X<" || gameBoard[i, j] == "> <")
                    {
                        gameBoard[i, j] = " O ";
                    }
                }
            }
        }

        public void TitleScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("\t====----====----====----====----====----====----====----====----====");
            Console.WriteLine("\t| .'`+~~    o_.      ~~+`'._.'`+~~        o-_  ~~+`'._.'`+~~    ., |");
            Console.WriteLine("\t|  _o -_~~+`'._.'`+~~   ..__      ~~+`'._.'`+~~      ..     ~~+`'  |");
            Console.WriteLine("\t|                                                                  |");
            Console.Write("\t|    ___o.o-");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("      Welcome to C# console Battleship.");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("    _-o--~      |");
            Console.WriteLine("\t|                                                                  |");
            Console.WriteLine("\t| ~~+`'._.'`+~~             ~~+`'._.'`+~~     ..o-    ~~+`'._.'`+  |");
            Console.WriteLine("\t| _o    o_- .  ~~+`'._.'`+~~    o.       ~~+`'._.'`+~~     o._     |");
            Console.WriteLine("\t====----====----====----====----====----====----====----====----====\n\n\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t             >  To start the game press the SPACEBAR  <\n\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t                      Any other key will exit");
            Console.ResetColor();
        }
    }
}
