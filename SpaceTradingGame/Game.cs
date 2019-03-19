using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Main 
namespace SpaceTradingGame
{
    public static class Game

    {   //Character name
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
}
