using System;
namespace DiceGame
{
    class Test
    {
        public static void Main(string[] args)
        {

            int playerone;
            int playertwo;

            int playerOnePts = 0; 
            int playertwoPts = 0;
            
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice");
                Console.ReadKey();

                playerone = random.Next(1 ,10);
                Console.WriteLine("You rolled a Dice: " + playerone );

                Console.WriteLine(".....");
                System.Threading.Thread.Sleep(1000);

                playertwo = random.Next(1 ,10);
                Console.WriteLine("Enemy Rolled a Dice: " + playertwo);

                if(playerone > playertwo)
                {
                    playerOnePts++;
                    Console.WriteLine("Player one wins this round!");
                    Console.WriteLine("......");
                    System.Threading.Thread.Sleep(1000);
                }else if(playerone < playertwo)
                {
                    Console.WriteLine("......");
                    System.Threading.Thread.Sleep(1000);
                    playertwoPts++;
                    Console.WriteLine("Player two wins this Round!");
                }
                else
                {
                    Console.WriteLine("......");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Draw");
                }
                Console.WriteLine("The Scores is now - PLAYER ONE: " + playerOnePts + ". PLAYER TWO: " + playertwo + ".");
                Console.WriteLine();
            }
            if (playerOnePts > playertwoPts)
            {
                Console.WriteLine("PLAYER ONE WINS!");
            }
            else if (playerOnePts < playertwoPts) {
                Console.WriteLine("PLAYER TWO WINS!");
            }
            else
            {
                Console.WriteLine("NO ONE WINS!");
            }
                Console.ReadKey();
        }
    }
}
