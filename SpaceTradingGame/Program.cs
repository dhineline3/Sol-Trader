using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTradingGame
{
    class Program
    {
        static void Main()
        {
            string CharacterName;

            Console.WriteLine("SOL TRADER");
            Console.WriteLine("Welcome to Sol Trader young adventurer!");
            Console.WriteLine("The year is 2147. Exploring the stars has become a hobby for many as space travel becomes commonplace.");
            Console.WriteLine("You have just graduated from the stellar business academy with a degree in intergalatic finance! Congratulations!");
            Console.WriteLine("Your father rewards you with your first spaceship. Will you fulfill your dreams of becoming a space trading mogul?");
            Console.WriteLine("Or will you die alone, penniless, drifting through space, living through your dreams in crysosleep?");
            Console.WriteLine("Choose your path. Your journey begins now!");
            Console.Write("Please enter your character name: ");
            CharacterName = Console.ReadLine();
            Console.WriteLine("Great! Your character name is now " + CharacterName + ". Good Luck!");
            Console.ReadKey();
            Console.WriteLine("Daniel Hineline is Awesome!");
        }
    }
}
