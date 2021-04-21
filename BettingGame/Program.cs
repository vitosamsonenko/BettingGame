using System;
using TwoGuysGiveCashToEachOther;

namespace BettingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.75;
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Guy player = new Guy() {Name = name, Cash = 100 };
            Console.WriteLine("Hello {0} and welcome to our casino. The odds are {1}", player.Name, odds);

            while (player.Cash > 0) 
            {
                player.WriteMyInfo();
                Console.WriteLine("How much do you want to bet:");
                string howMuch = Console.ReadLine();
                if (!int.TryParse(howMuch, out int amount)) 
                {
                    Console.WriteLine("{0} is not a correct amount. Try again");
                    continue;
                }
                int pot = player.GiveCash(amount)*2;


                if (random.NextDouble() > odds) 
                {
                    Console.WriteLine("You win");
                    player.ReceiveCash(pot);
                }
                else 
                {
                    Console.WriteLine("Bad luck. You lose");
                    
                }

 
            }
            Console.WriteLine("{0} ran out of cash.\n House always wins", player.Name);
            
            
        }
    }
}
