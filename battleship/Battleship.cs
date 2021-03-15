namespace battleship
{
    class Battleship
    {
        public int[,] location1 = new int[1, 1];
        public int[,] location2 = new int[1, 1];
        public int[,] location3 = new int[1, 1];

        public int[,] RandomShipLoc()
        {
            //random number for vertical or horizontal
            //random number 0-9 + 1 for location1
            //add values to make loc2 and loc3 adjascent by vertical or horizontal.
            return location1;
        }
    }
}
