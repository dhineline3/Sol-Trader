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

        public static void StandardMenu()
        {
            string input = "";
            Console.WriteLine(CharacterName + "What would you like to do?");
            Console.WriteLine("A. View Inventory | B. Visit Intergalatic Market | C. Travel to a different system");
            input = Console.ReadLine();
            input = input.ToUpper();
            Console.Clear();
            if (input == "A")
            {
                Console.WriteLine("Here is your current Inventory");
                ItemsList.CurrentInventory();

            }
            else if (input == "C")
            {
                Console.WriteLine("Welcome to the Intergalactic Market!");

            }
            else if (input == "C")
            {
                Console.WriteLine(CharacterName + ", where would you like to travel to next?");
                TravelMenu.Planets();

            }            
        }
        static void SpacePirates()
        {
            Console.WriteLine("You have been intercepted by Space Pirates! " +
                "\nThey hail you on the communications channel ordering you to lower you shields to be boarded or you will be fired upon! \n" +
                "What will you do? \n" +
                "Will you A. Lower Shields | B. Attempt to negotiate | C. Attempt to flee | D. Open fire!");
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
