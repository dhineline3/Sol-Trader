﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTradingGame
{
    public static class Game
    {
        //character name
        static string CharacterName = "Daniel Hineline";

        //print out game title and overview
        public static void StartGame()
        {
            //the next few lines will have your own content
            Console.WriteLine("SOL TRADER");
            Console.WriteLine();
            Console.WriteLine("Welcome to Sol Trader young adventurer!");
            Console.WriteLine("The year is 2147. Exploring the stars has become a hobby for many as space travel becomes commonplace.");
            Console.WriteLine("You have just graduated from the stellar business academy with a degree in intergalatic finance! Congratulations!");
            Console.WriteLine("Your father rewards you with your first spaceship. Will you fulfill your dreams of becoming a space trading mogul?");
            Console.WriteLine("Or will you die alone, penniless, drifting through space, living through your dreams in crysosleep?");
            Console.WriteLine();
            Console.WriteLine("Choose your path. Your journey begins now!");
            Console.WriteLine();
            NameCharacter();
        }
        //ask player for a name and save it
        static void NameCharacter()
        {

            Console.Write("Please enter your character name: ");
            CharacterName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Great! Your character name is now " + CharacterName + ". Good Luck!");
            Console.ReadKey();
        }

    }
    class Item
    {

    }
    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Console.ReadKey();

        }
    }
}
