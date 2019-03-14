using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTradingGame
{   
    //Class Program and Main method
    class Program
    {
        static void Main()
        {
            //Main title text
            Game.StartGame();
            string myText = "Welcome to Sol Trader young adventurer!\n\n" +
            "The year is 2147. Exploring the stars has become a hobby for many as space travel becomes commonplace.\n\n" +
            "You have just graduated from the stellar business academy with a degree in intergalatic finance! Congratulations!\n" +
            "Unfortunately your father and only relative has died.\n" +
            "Fortunately he left you his spaceship! Awesome!\n" +
            "Unfortunately it isn't in the best shape....but it is fully capable of taking you to the stars!\n\n" +
            "Will you fulfill your dreams of becoming a space trading mogul?\n" +
            "Or will you die alone, penniless, drifting through space, living through your dreams in crysosleep?\n\n" +
            "Choose your path. Your journey begins now!\n\n" +
            "Press enter to continue...";            
            
            //Loop that makes main title text write out like a typewriter
            for (int i = 0; i < myText.Length; i++)
            {
                Console.Write(myText[i]);
                System.Threading.
                Thread.Sleep(5);
            }
            //Calls the NameCharacter method
            Game.NameCharacter();

            //End of game text method
            void EndGame()
            {
                Console.WriteLine("End of story text goes here...");
                Console.WriteLine("Thankyou for playing my guy young traveler. We hope you ejoyed your journey through the endless expanse of space!");
                Console.WriteLine("Press enter to exit.");
            }
        }
    }
}

