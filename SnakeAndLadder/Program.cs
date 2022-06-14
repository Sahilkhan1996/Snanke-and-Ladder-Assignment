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
            while (playerposition < 100)
            {

                Random r = new Random();
                int dienumber = r.Next(1, 7);
                Console.WriteLine("Rolling die rolling number for the firsttime: " + dienumber);

                //uc3: checking for option play, no play            
                Random r2 = new Random();
                int gametime = r2.Next(0, 3);
                Console.WriteLine("snake or ladder checker:" + gametime);
                switch (gametime)
                {
                    case 0:
                        playerposition = playerposition + dienumber;
                        break;
                    case 1:

                        playerposition = playerposition - dienumber;

                        break;
                    default:
                        Console.WriteLine("No play");
                        break;
                }

                if (playerposition < 0)
                {
                    playerposition = 0;
                }
                Console.WriteLine("final position checker: " + playerposition);
            }
            Console.WriteLine("player beat the snakes and completed the game" + playerposition);


        }
    }
}