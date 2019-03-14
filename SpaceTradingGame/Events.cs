using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Standard menu screen that will be present every time a user visits a new system
//Want to create a way to have a random event from a list of events that happens every time you travel from one system to another
//These events will give the user 2 choices which will each either reward or harm the user

namespace SpaceTradingGame
{
    class Events
    {
        private static string CharacterName;

        static void StandardMenu()
        {
            string input = "";
            Console.WriteLine(CharacterName + " ,What would you like to do?");
            Console.WriteLine("A. View Inventory | B. Visit Intergalatic Market | C. Travel to a different system");
            input = Console.ReadLine();
            input = input.ToUpper();
            if (input == "A")
            {
                Console.WriteLine("Here is your current Inventory");

            }
            else if (input == "C")
            {
                Console.WriteLine("Welcome to the Intergalactic Market!");

            }
            else if (input == "C")
            {
                Console.WriteLine(CharacterName + ", where would you like to travel to next?");
                Console.WriteLine("Choose a Destination: A. Earth | B. Pandora | C. Reach | D. Proixima Centauri | E. Gliese 832 |)");
                string destination = "";
                destination = Console.ReadLine();
                destination = destination.ToUpper();
            }            
        }
        static void SpacePirates()
        {

        }
        static void FloatingDebris()
        {

        }
        static void AbandonedSpaceShip()
        {

        }
        static void GlitteringObject()
        {

        }
        static void Alien()
        {

        }
        static void StolenCargo()
        {

        }
        
    }
}
