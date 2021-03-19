namespace battleship
{
    class Player
    {
        public const int MAX_SHOTS = 10;
        public int shots = 0;
        public int hits = 0;
        public int guessX;
        public int guessY;

        public void ResetPlayer()
        {
            shots = 0;
            hits = 0;
            guessX = -1;
            guessY = -1;
        }
    }
}
