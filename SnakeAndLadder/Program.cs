using System;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {

        static int playerposition1;
        static int playerposition2;


        static int count;
        static void Main(string[] args)
        {
            while (playerposition1 < 100 || playerposition2 < 100)
            {
                player1();
                player2();
            }
            if (playerposition1 == 100)
            {
                Console.WriteLine("player1 won the gane");
            }
            if(playerposition2==100)
            {
                Console.WriteLine("player2has won the game");
            }

        }
        public static void rolldie1()
        {


            Random r = new Random();
            int dienumber = r.Next(1, 7);
            player1();
        }
        public static void rolldie2()
        {


            Random r = new Random();
            int dienumber = r.Next(1, 7);
            player2();
        }


        public static void player1()
        {
            count++;
            Console.WriteLine("number of time the die is rolling" + count);
            Random r = new Random();
            int dienumber = r.Next(1, 7);
            //Console.WriteLine("Rolling die rolling number for the firsttime: " + dienumber);

            //uc3: checking for option play, no play            
            Random r2 = new Random();
            int gametime = r2.Next(0, 3);
            //Console.WriteLine("snake or ladder checker:" + gametime);
            switch (gametime)
            {
                case 0:
                    playerposition1 = playerposition1 + dienumber;
                    rolldie1();

                    break;
                case 1:

                    playerposition1 = playerposition1 - dienumber;

                    break;
                default:
                    Console.WriteLine("No play");
                    break;
            }
            if (playerposition1 > 100)
            {
                playerposition1 = playerposition1 - dienumber;
            }
            if (playerposition1 < 0)
            {
                playerposition1 = 0;
            }
            //Console.WriteLine("final position checker: " + playerposition1);
            Console.WriteLine("player beat the snakes and completed the game: " + playerposition1 + " number of time the die rolled: " + count);
        }








        public static void player2()
        {
            count++;
            Console.WriteLine("number of time the die is rolling" + count);
            Random r = new Random();
            int dienumber = r.Next(1, 7);
         //   Console.WriteLine("Rolling die rolling number for the firsttime: " + dienumber);

            //uc3: checking for option play, no play            
            Random r2 = new Random();
            int gametime = r2.Next(0, 3);
           // Console.WriteLine("snake or ladder checker:" + gametime);
            switch (gametime)
            {
                case 0:
                    playerposition2 = playerposition2 + dienumber;
                    rolldie2();
                    break;
                case 1:

                    playerposition2 = playerposition2 - dienumber;

                    break;
                default:
                    Console.WriteLine("No play");
                    break;
            }
            if (playerposition2 > 100)
            {
                playerposition2 = playerposition2 - dienumber;
            }
            if (playerposition2 < 0)
            {
                playerposition2 = 0;
            }
            //Console.WriteLine("final position checker: " + playerposition2);
            Console.WriteLine("player2 beat the snakes and completed the game: " + playerposition2 + " number of time the die rolled: " + count);
        }



    }
}



