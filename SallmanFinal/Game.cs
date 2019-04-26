using System;
using System.Collections.Generic;
using System.Text;

namespace SallmanFinal
{
    class Game
    {
        static string characterName = "Unknown Player";

        public static void StartGame()
        {
            string title = @"
     ___       ___                                      ___       ___             
    (   )     (   )                                    (   )     (   )            
     | |_      | | .-.     .--.        .-..     .---.   | |_      | | .-.         
    (   __)    | |/   \   /    \      /    \   / .-, \ (   __)    | |/   \        
     | |       |  .-. .  |  .-. ;    ' .-,  ; (__) ; |  | |       |  .-. .        
     | | ___   | |  | |  |  | | |    | |  . |   .'`  |  | | ___   | |  | |        
     | |(   )  | |  | |  |  |/  |    | |  | |  / .'| |  | |(   )  | |  | |        
     | | | |   | |  | |  |  ' _.'    | |  | | | /  | |  | | | |   | |  | |        
     | ' | |   | |  | |  |  .'.-.    | |  ' | ; |  ; |  | ' | |   | |  | |   .-.  
     ' `-' ;   | |  | |  '  `-' /    | `-'  ' ' `-'  |  ' `-' ;   | |  | |  (   ) 
      `.__.   (___)(___)  `.__.'     | \__.'  `.__.'_.   `.__.   (___)(___)  `-'  
                                     | |                                          
                                    (___)                                         
            ";

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(title);
            Console.WriteLine("     by Marie Sallman");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("");
            NameCharacter();

        }

        static void NameCharacter()
        {
            Console.WriteLine("Please enter your name: ");
            characterName = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Welcome, {0}.  You have an interesting journey ahead of you.  Are you sure you're ready?", characterName);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }


    }
}
