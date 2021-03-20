using System;

namespace battleship
{
    class Battleship
    {
        static Random random = new Random();

        public int Lives { get; private set; } = 5;
        public int ShipDirectionX { get; private set; }
        public int ShipDirectionY { get; set; }
        public int RandomLocationX { get; private set; }
        public int RandomLocationY { get; private set; }
        public int[] location1 = new int[2];
        public int[] location2 = new int[2];
        public int[] location3 = new int[2];
        public int[] location4 = new int[2];
        public int[] location5 = new int[2];

        public void ResetLives()
        {
            Lives = 5;
        }

        public void TakeHit()
        {
            Lives--;
        }

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
                ShipDirectionX = 0;
                ShipDirectionY = 1;
                RandomLocationX = randomNumber(11);
                RandomLocationY = randomNumber(6);
            }
            else
            {
                ShipDirectionX = 1;
                ShipDirectionY = 0;
                RandomLocationX = randomNumber(6);
                RandomLocationY = randomNumber(11);
            }

            location1.SetValue(RandomLocationX, 0);
            location1.SetValue(RandomLocationY, 1);

            location2.SetValue(RandomLocationX + ShipDirectionX, 0);
            location2.SetValue(RandomLocationY + ShipDirectionY, 1);

            location3.SetValue(RandomLocationX + ShipDirectionX * 2, 0);
            location3.SetValue(RandomLocationY + ShipDirectionY * 2, 1);

            location4.SetValue(RandomLocationX + ShipDirectionX * 3, 0);
            location4.SetValue(RandomLocationY + ShipDirectionY * 3, 1);

            location5.SetValue(RandomLocationX + ShipDirectionX * 4, 0);
            location5.SetValue(RandomLocationY + ShipDirectionY * 4, 1);
        }
    }
}
