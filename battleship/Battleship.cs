using System;

namespace battleship
{
    class Battleship
    {
        static Random random = new Random();

        public bool IsBattleshipSunk { get; set; } = true;
        public int Lives { get; private set; } = 5;
        public int ShipDirectionX { get; private set; }
        public int ShipDirectionY { get; private set; }
        public int RandomLocationX { get; private set; }
        public int RandomLocationY { get; private set; }
        private int[] location1 = new int[2];
        private int[] location2 = new int[2];
        private int[] location3 = new int[2];
        private int[] location4 = new int[2];
        private int[] location5 = new int[2];

        public void ResetLives()
        {
            Lives = 5;
        }

        public void TakeHit()
        {
            Lives--;
        }

        public void RandomShipLocation()
        {
            var shipOrientationRandomizer = random.Next(0, 2);

            if (shipOrientationRandomizer == 0)
            {
                ShipDirectionX = 0;
                ShipDirectionY = 1;
                RandomLocationX = random.Next(1, 11);
                RandomLocationY = random.Next(1, 6);
            }
            else
            {
                ShipDirectionX = 1;
                ShipDirectionY = 0;
                RandomLocationX = random.Next(1, 6);
                RandomLocationY = random.Next(1, 11);
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

        public bool IsTargetHit(int guessX, int guessY)
        {
            return (guessX == location1[0]
                        || guessX == location2[0]
                        || guessX == location3[0]
                        || guessX == location4[0]
                        || guessX == location5[0])
                        && (guessY == location1[1]
                        || guessY == location2[1]
                        || guessY == location3[1]
                        || guessY == location4[1]
                        || guessY == location5[1]);
        }

        public bool SetIsBattleshipSunk()
        {
            return IsBattleshipSunk = !IsBattleshipSunk;
        }
    }
}
