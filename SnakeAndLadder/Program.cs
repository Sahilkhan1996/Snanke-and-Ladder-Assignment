using System;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {
        static int playerposition;

        static void Main(string[] args)
        {
            //uc1: the position of player startng from 0
            Console.WriteLine("The position of player is: " + playerposition);


            //uc2: the player roll the die for the 1st time.
            Random r = new Random();
            int dienumber = r.Next(1, 7);
            Console.WriteLine("player Rolling die rolling and number comes is: " + dienumber);

        }
    }
}
