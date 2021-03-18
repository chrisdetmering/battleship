using System;

namespace battleship
{
    class Battleship
    {
        Random random = new Random();
        public int lives = 5;
        public int[] location1 = new int[2];
        public int[] location2 = new int[2];
        public int[] location3 = new int[2];
        public int[] location4 = new int[2];
        public int[] location5 = new int[2];
        private int shipDirectionX;
        private int shipDirectionY;
        private int randomLocationX;
        private int randomLocationY;

        private int randomNumber(int max)
        {
            var randomLocation = random.Next(1, max);
            return randomLocation;
        }

        public void RandomShipLocation()
        {
            var shipDirectionRandomizer = random.Next(0, 2);

            if (shipDirectionRandomizer == 0)
            {
                shipDirectionX = 0;
                shipDirectionY = 1;
                randomLocationX = randomNumber(11);
                randomLocationY = randomNumber(6);
            }
            else
            {
                shipDirectionX = 1;
                shipDirectionY = 0;
                randomLocationX = randomNumber(6);
                randomLocationY = randomNumber(11);
            }

            location1.SetValue(randomLocationX, 0);
            location1.SetValue(randomLocationY, 1);

            location2.SetValue(randomLocationX + shipDirectionX, 0);
            location2.SetValue(randomLocationY + shipDirectionY, 1);

            location3.SetValue(randomLocationX + shipDirectionX * 2, 0);
            location3.SetValue(randomLocationY + shipDirectionY * 2, 1);

            location4.SetValue(randomLocationX + shipDirectionX * 3, 0);
            location4.SetValue(randomLocationY + shipDirectionY * 3, 1);

            location5.SetValue(randomLocationX + shipDirectionX * 4, 0);
            location5.SetValue(randomLocationY + shipDirectionY * 4, 1);
        }

        public void ResetLives()
        {
            lives = 5;
        }
    }
}
