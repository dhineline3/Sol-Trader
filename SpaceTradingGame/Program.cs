using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTradingGame
{

    public static class Game
    {
        //Character name
        static string CharacterName;

        //Main Title Screen
        public static void StartGame()
        {





            //Main Title color
           Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Main Title
           Console.WriteLine(@"
                                                    ███████╗ ██████╗ ██╗         ████████╗██████╗  █████╗ ██████╗ ███████╗██████╗                         ^
                                                    ██╔════╝██╔═══██╗██║         ╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔══██╗                      /SSS\
                                                    ███████╗██║   ██║██║            ██║   ██████╔╝███████║██║  ██║█████╗  ██████╔╝                     |SPACE|
                                                    ╚════██║██║   ██║██║            ██║   ██╔══██╗██╔══██║██║  ██║██╔══╝  ██╔══██╗                     |SPACE|
                                                    ███████║╚██████╔╝███████╗       ██║   ██║  ██║██║  ██║██████╔╝███████╗██║  ██║                     |SPACE|
                                                    ╚══════╝ ╚═════╝ ╚══════╝       ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═════╝ ╚══════╝╚═╝  ╚═╝                     |SPACE|   
                                                                                                                                                      /|SPACE|\
                                                                                                                                                     /S |SSS| S\
                                                                                                                                                    /SS |S S| SS\
                                                                                                                                                        |S S|
                                                                                                                                                  ****************
                                                                                                                                                  ****************

                                                                                                           ");

            //Main Title Text Color
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press enter to being your adventure...");
            Console.ReadKey();

            //Clearing the prior specific line
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            ClearCurrentConsoleLine();

            //Method to set up way to clear lines 
            void ClearCurrentConsoleLine()
            {
                int currentLineCursor = Console.CursorTop;
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, currentLineCursor);
                
            }
        }
        //Ask player for a name and save it
        public static void NameCharacter()
        {
            Console.ReadKey();
            Console.Write("Please enter your character name: ");
            CharacterName = Console.ReadLine();
            Console.WriteLine($"\nGreat! Your character name is now {CharacterName}. Good Luck!");

        }
    }
    //Creating item class
    class Item
    {

    }
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


        }
    }
}

