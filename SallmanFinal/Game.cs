using System;
using System.Collections.Generic;
using System.Text;

namespace SallmanFinal
{
    class Game
    {
        static string characterName = "Unknown Player";
        static string beginGame;
        static int occupation;

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

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("");
            NameCharacter();

        }

        static void NameCharacter()
        {
            Console.WriteLine("Please enter your name: ");
            characterName = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Welcome, {0}.  You have an interesting journey ahead of you.  Are you sure you're ready?", characterName);
            Console.WriteLine("Please enter y for yes or n for no.");
            beginGame = Console.ReadLine();

            while (beginGame != "y")
            {
                
                if (beginGame == "n")
                {
                    Console.WriteLine("I see.  That is a shame.  Perhaps you were not meant to travel the path.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if (beginGame != "y" || beginGame != "n")
                {
                    Console.WriteLine("Perhaps I wasn't clear.  Please enter y for yes or n for no.");
                    beginGame = Console.ReadLine();
                }
            }

            Console.WriteLine("Then let us begin.  Press ENTER to continue.");
            Console.ReadKey();
            FirstCycle();
        }

        static void FirstCycle()
        {
            string bang = @"
     ▄▄▄▄▄▄▄▄▄▄   ▄▄▄▄▄▄▄▄▄▄▄  ▄▄        ▄  ▄▄▄▄▄▄▄▄▄▄▄                                                                  
    ▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌▐░░▌      ▐░▌▐░░░░░░░░░░░▌                                                                 
    ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░▌░▌     ▐░▌▐░█▀▀▀▀▀▀▀▀▀                                                                  
    ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌▐░▌    ▐░▌▐░▌                                                                           
    ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌▐░▌ ▐░▌   ▐░▌▐░▌ ▄▄▄▄▄▄▄▄                                                                  
    ▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌▐░▌  ▐░▌  ▐░▌▐░▌▐░░░░░░░░▌                                                                 
    ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░▌   ▐░▌ ▐░▌▐░▌ ▀▀▀▀▀▀█░▌                                                                 
    ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌    ▐░▌▐░▌▐░▌       ▐░▌                                                                 
    ▐░█▄▄▄▄▄▄▄█░▌▐░▌       ▐░▌▐░▌     ▐░▐░▌▐░█▄▄▄▄▄▄▄█░▌                                                                 
    ▐░░░░░░░░░░▌ ▐░▌       ▐░▌▐░▌      ▐░░▌▐░░░░░░░░░░░▌                                                                 
     ▀▀▀▀▀▀▀▀▀▀   ▀         ▀  ▀        ▀▀  ▀▀▀▀▀▀▀▀▀▀▀                                                                  
                                                                                                                     
            ";

            string crash = @"
                ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄         ▄                                      
               ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌       ▐░▌                                     
               ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░▌       ▐░▌                                     
               ▐░▌          ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌          ▐░▌       ▐░▌                                     
               ▐░▌          ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄█░▌                                     
               ▐░▌          ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌                                     
               ▐░▌          ▐░█▀▀▀▀█░█▀▀ ▐░█▀▀▀▀▀▀▀█░▌ ▀▀▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌                                     
               ▐░▌          ▐░▌     ▐░▌  ▐░▌       ▐░▌          ▐░▌▐░▌       ▐░▌                                     
               ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌      ▐░▌ ▐░▌       ▐░▌ ▄▄▄▄▄▄▄▄▄█░▌▐░▌       ▐░▌                                     
               ▐░░░░░░░░░░░▌▐░▌       ▐░▌▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░▌       ▐░▌                                     
                ▀▀▀▀▀▀▀▀▀▀▀  ▀         ▀  ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀         ▀                                      
                                                                                                                     
            ";

            string screech = @"
 ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄         ▄ 
▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌       ▐░▌
▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌       ▐░▌
▐░▌          ▐░▌          ▐░▌       ▐░▌▐░▌          ▐░▌          ▐░▌          ▐░▌          ▐░▌          ▐░▌       ▐░▌
▐░█▄▄▄▄▄▄▄▄▄ ▐░▌          ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌          ▐░█▄▄▄▄▄▄▄█░▌
▐░░░░░░░░░░░▌▐░▌          ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌          ▐░░░░░░░░░░░▌
 ▀▀▀▀▀▀▀▀▀█░▌▐░▌          ▐░█▀▀▀▀█░█▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌          ▐░█▀▀▀▀▀▀▀█░▌
          ▐░▌▐░▌          ▐░▌     ▐░▌  ▐░▌          ▐░▌          ▐░▌          ▐░▌          ▐░▌          ▐░▌       ▐░▌
 ▄▄▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░▌      ▐░▌ ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌       ▐░▌
▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌       ▐░▌
 ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀         ▀ 
                                                                                                                     
            ";

            
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine(bang);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(crash);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(screech);
            Console.WriteLine("");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("The ringing in your ears is disorienting as you slowly come to.");
            Console.ReadKey();

            
            Console.WriteLine("What just happened?");
            Console.ReadKey();
            Console.WriteLine("You try to think back to what you were just doing but a searing pain shoots through your head.");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("Easy now, let's start at the beginning.");
            Console.ReadKey();
            Console.WriteLine("Your name.  Your name is...  It's...  {0}?  Yes, {1} sounds right.", characterName, characterName);
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("You work as a...  A...  What was your occupation again?");
            Console.WriteLine("");
            Console.WriteLine("1. I'm an actor.  I've always enjoyed working with other people and I get along with just about anyone.");
            Console.WriteLine("2. I'm skilled at hard labor, I like to work with my hands and I'm physically very fit.");
            Console.WriteLine("3. I work with computers.  I'm very comfortable working through complex problems to find a solution.");
            Console.WriteLine("4. I consider myself a jack of all trades, I'll take on whatever job you have.  I might not be the best, but I'll get the job done one way or another.");
            Console.WriteLine("");
            Console.WriteLine("Please enter in a number 1 through 4.");

            string input = Console.ReadLine();
            Int32.TryParse(input, out occupation);

            while(occupation != 1 && occupation != 2 && occupation != 3 && occupation != 4)
            {
                Console.WriteLine("You have entered {0}.  This is not a valid entry, please enter a number 1 through 4.", occupation);
                input = Console.ReadLine();
                Int32.TryParse(input, out occupation);
            }

            Console.WriteLine("Cool");

            Console.ReadKey();

        }


    }
}
