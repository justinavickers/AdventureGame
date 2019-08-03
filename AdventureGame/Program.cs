using System;

namespace AdventureGame
{
    class Program
    {
        //string CharacterName = "";
        static void Main()        {

            string CharacterName = "Lemony Snickett";

            Console.WriteLine("Adventure Game!");
            Console.WriteLine("Welcome to my game...");
            Console.WriteLine("What would you like your character's name to be?");
            CharacterName = Console.ReadLine();
            Console.WriteLine("Great! Your character is now named " + CharacterName);

            Console.Read();

        }
    }
}
