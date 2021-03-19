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
                    if (gameBoardArr[i, j] == "> <")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(gameBoardArr[i, j] + " \t");
                        Console.ResetColor();
                    }
                    else if (gameBoardArr[i, j] == ">X<")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(gameBoardArr[i, j] + " \t");
                        Console.ResetColor();
                    }
                    else if (gameBoardArr[i, j] == " O ")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write(gameBoardArr[i, j] + " \t");
                        Console.ResetColor();
                    }
                    else 
                    Console.Write(gameBoardArr[i, j] + " \t");
                }
                Console.WriteLine("\n \n");
            }
        }

        public void TitleScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("\t====----====----====----====----====----====----====----====----====");
            Console.WriteLine("\t| .'`+~~    o_.      ~~+`'._.'`+~~        o-_  ~~+`'._.'`+~~    ., |");
            Console.WriteLine("\t|  _o -_~~+`'._.'`+~~   ..__      ~~+`'._.'`+~~      ..     ~~+`'  |");
            Console.WriteLine("\t|                                                                  |");
            Console.WriteLine("\t|    ___o.o-      Welcome to C# console Battleship.    _-o--~      |");
            Console.WriteLine("\t|                                                                  |");
            Console.WriteLine("\t| ~~+`'._.'`+~~             ~~+`'._.'`+~~     ..o-    ~~+`'._.'`+  |");
            Console.WriteLine("\t| _o    o_- .  ~~+`'._.'`+~~    o.       ~~+`'._.'`+~~     o._     |");
            Console.WriteLine("\t====----====----====----====----====----====----====----====----====\n\n\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t             >  To start the game press the SPACEBAR  <\n\n");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\t                      Any other key will exit");
            Console.ResetColor();
        }
    }
}
