using System;

namespace battleship
{
    class Battleship
    {
        private int[] location1 = new int[2];
        private int[] location2 = new int[2];
        private int[] location3 = new int[2];
        private int shipDirectionX;
        private int shipDirectionY;

        public int[] RandomShipLoc()
        {
            Random random = new Random();

            var shipDirectionRandomizer = random.Next(0, 2);
            if (shipDirectionRandomizer == 0)
            {
                shipDirectionX = 0;
                shipDirectionY = 1;
            }
            else
            {
                shipDirectionX = 1;
                shipDirectionY = 0;
            }
            Console.WriteLine(shipDirectionRandomizer);

            var randomLocationX = random.Next(1, 11);
            var randomLocationY = random.Next(1, 11);

            location1.SetValue(randomLocationX, 0);
            location1.SetValue(randomLocationY, 1);
            location2.SetValue(randomLocationX + shipDirectionX, 0);
            location2.SetValue(randomLocationY + shipDirectionY, 1);
            location3.SetValue(randomLocationX + shipDirectionX * 2, 0);
            location3.SetValue(randomLocationY + shipDirectionY * 2, 1);

            Console.Write(location1[0] + ", ");
            Console.WriteLine(location1[1]);
            Console.Write(location2[0] + ", ");
            Console.WriteLine(location2[1]);
            Console.Write(location3[0] + ", ");
            Console.WriteLine(location3[1]);

            //random number for vertical or horizontal
            //random number 0-9 + 1 for location1
            //add values to make loc2 and loc3 adjascent by vertical or horizontal.
            return location1;
        }
    }
}
