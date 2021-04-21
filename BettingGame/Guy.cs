using System;
using System.Collections.Generic;
using System.Text;

namespace TwoGuysGiveCashToEachOther
{
    class Guy
    {
        public string Name;
        public int Cash;
        /// <summary>
        /// Writes my name and the amount of cash I have to the console
        /// </summary>
        public void WriteMyInfo()
        {
            Console.WriteLine("{0} has {1} bucks", Name, Cash);
        }
        /// <summary>
        /// Gives some of my cash, removing it from my wallet, if I have enough
        /// </summary>
        /// <param name="amount">Amount of cash to give</param>
        /// <returns>Amount of cash removed from my wallet</returns>
        public int GiveCash(int amount) 
        {
            if (amount < 0) 
            {
                Console.WriteLine("{0} says: the amount {1} is too negative", Name, amount);
                return 0;
            }
            if (amount > Cash) 
            {
                Console.WriteLine("{0} says: I don't have enough cash to give you {1} bucks", Name, amount);
                return 0;
            }
            Cash -= amount;
            return amount;

        }
        /// <summary>
        /// Receive some cash, adding it to my wallet
        /// </summary>
        /// <param name="amount"></param>
        public void ReceiveCash(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("{0} says: {1} is not the amount that I'm going to take", Name, amount);
                return;
            }
            Cash += amount;

        }
    }
}
