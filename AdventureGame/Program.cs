using System;

namespace AdventureGame
{
   public static class Game
    {
        static string CharacterName = "";

        public static void StartGame()
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Welcome to Middle Earth...");
            NameCharacter();
        }
        static void NameCharacter()
        {
            Console.Write("What would you like your character's name to be?");
            CharacterName = Console.ReadLine();

            Console.WriteLine("Welcome, " + CharacterName + " and safe travels!");
        }
    }
    class Item
    {
    }

   
    class Program
    {
        static void Main()        {


            Game.StartGame();
            Console.Read();

        }
    }
}
