using System;

namespace BettingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.75;
            Guy player = new Guy("The player", 100);

            Console.WriteLine($"Welcome " + player.Name + " " + player.Cash);

            while
            {
                Console.WriteLine(player.Cash);
                Console.WriteLine("How much do you want to bet?");
                string howMuch = Console.ReadLine();

                // see if amount entered is an integer
                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = amount * 2;

                    //picks random number between 0-1
                    int randomNumber = random.Next(0, 1);
                    if (randomNumber > odds)
                    {
                        player.Cash += pot;     // player wins and wins the pot
                    }
                    else
                    {
                        player.Cash -= pot;     // plaer loses and loses the pot
                    }
                }
                else
                {
                    Console.WriteLine("Please enter amount to bet or a blank line to exit");
                }
            }    


        }
    }
}
