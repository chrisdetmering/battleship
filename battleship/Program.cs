using System;

namespace battleship
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int myInt = 10;
            byte myByte = (byte)myInt;
            double myDouble = (double)myByte;
            string myString = "false";
            myString = myInt.ToString();
            short myShort = (short)myInt;
            char myChar = 'x';
            long myLong = (long)myInt;
            decimal myDecimal = (decimal)myLong;
            myString = myString + myInt + myByte + myDouble + myChar + myDecimal;
            Console.WriteLine(myString);
        }
    }
}
