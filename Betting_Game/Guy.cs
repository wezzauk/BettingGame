using System;
using System.Collections.Generic;
using System.Text;

namespace BettingGame
{
    class Guy
    {
        public string Name;
        public int Cash;

        /// <summary>
        /// Writes my name and the amount of cash I have to the console.
        /// </summary>
        public void WriteMyInfo()
        {
            Console.WriteLine(Name + " has " + Cash + " bucks.");
        }

        /// <summary>
        /// Gives some of my cash, removing it from my wallet or printing to console I don't have enough
        /// </summary>
        /// <param name="amount">Amount of cash to give</param>
        /// <returns>
        /// the amount of cash removed from my wallet or 0 if I don't have enough cash.
        /// </returns>
        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says: " + amount + " isn't a valid amount");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine(Name + " says: " + "I don't have enough cash to give you " + amount);
                return 0;
            }
            Cash -= amount;
            return amount;
        }


        public void ReceiveCash(int amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine(Name + " says: " + amount + " isn't an amount I'll take");
            }
            else
            {
                Cash += amount;
            }
        }

    }
}
