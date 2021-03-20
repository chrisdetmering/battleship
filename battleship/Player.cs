namespace battleship
{
    class Player
    {
        public const int MAX_SHOTS = 10;
        public int Shots { get; private set; }
        public int Hits { get; private set; }
        public int guessX;
        public int guessY;

        public void ResetPlayer()
        {
            Shots = 0;
            Hits = 0;
            guessX = -1;
            guessY = -1;
        }

        public void Shoot()
        {
            Shots++;
        }

        public void HitCount()
        {
            Hits++;
        }
    }
}
