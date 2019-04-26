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
        static string viewStats;
        static List<string> Inventory = new List<string>();

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

            Console.ForegroundColor = ConsoleColor.Red;
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
            Console.ForegroundColor = ConsoleColor.White;
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
            Console.WriteLine("4. I consider myself a jack of all trades, I'll take on whatever job you have.");
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

            Console.WriteLine("");

            Stats character = new Stats();
            character.OccupationStats(occupation);

            Console.WriteLine("");

            Console.WriteLine("Speaking of stats, would you like to view your stats now?  Enter y for yes or n for no.");

            viewStats = Console.ReadLine();

            while (viewStats != "n")
            {

                if (viewStats == "y")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Your stats are as follows:");
                    character.ViewStats();
                    Console.ReadKey();
                    viewStats = "n";
                }
                else if (viewStats != "y" || viewStats != "n")
                {
                    Console.WriteLine("Perhaps I wasn't clear.  Please enter y for yes or n for no.");
                    viewStats = Console.ReadLine();
                }
            }

            viewStats = "s";

            Console.WriteLine("");
            Console.WriteLine("That's right, you're starting to remember.");
            Console.ReadKey();
            Console.WriteLine("You take a moment to observe your surroundings.  You seem to be in a car.");
            Console.WriteLine("Although, considering the condition it's in it's hard to even call it a car.");
            Console.ReadKey();
            Console.WriteLine("You're sitting in the driver's seat, the entirety of the passenger's side is caved in.");
            Console.WriteLine("You don't think anyone was with you in the car... You hope no one was with you in the car.");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("You reach up and touch your forehead, it stings and when you look at your hand you can see fresh blood on it.");
            Console.WriteLine("You think you can still open your door if you want to get out of the car.  You try the handle.");
            Console.ReadKey();

            string thunk = @"
████████╗██╗  ██╗██╗   ██╗███╗   ██╗██╗  ██╗
╚══██╔══╝██║  ██║██║   ██║████╗  ██║██║ ██╔╝
   ██║   ███████║██║   ██║██╔██╗ ██║█████╔╝ 
   ██║   ██╔══██║██║   ██║██║╚██╗██║██╔═██╗ 
   ██║   ██║  ██║╚██████╔╝██║ ╚████║██║  ██╗
   ╚═╝   ╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝  ╚═╝
                                            
            ";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(thunk);
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("You tumble unceremoniously to the ground as the door pops open.");
            Console.ReadKey();
            Console.WriteLine("Your body aches as you slowly get to your feet.  It's a miracle you didn't break anything from that crash.");
            Console.WriteLine("");
            Console.ReadKey();
            Console.WriteLine("You look up to the sky to see the sun is just starting to go down, you've got an hour or two of daylight left at best.");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("Looking around you find yourself on a stretch of road surrounded by a dense forest of trees.");
            Console.WriteLine("It seems like your car must have veered off the road at some point and collided with one of the trees.");
            Console.WriteLine("Did you fall asleep at the wheel?  That doesn't sound like you.");
            Console.ReadKey();

            Console.WriteLine("Where were you going again?");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("You can't seem to remember.");
            Console.WriteLine("");
            Console.ReadKey();

            Console.WriteLine("You fumble in your pocket, fishing out your cellphone.  The battery reads 72%, it doesn't seem to be getting any signal.");
            Console.WriteLine("There are three unread text messages however.  Two are from a contact simply called <3<3, the other is from someone named Charon.");
            Console.ReadKey();
            Console.WriteLine("");

            Inventory.Add("Cellphone");

            Console.WriteLine("Neither name is familiar to you.  You decide to check the two texts from <3<3 first.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Text 1 reads:");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("");
            Console.WriteLine("{0}, don't forget to call Alex, he can give you directions.", characterName);
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("");
            Console.WriteLine("The second text reads:");

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("");
            Console.WriteLine("Alex said you haven't called him yet.  I know you two aren't on the best terms, but this is silly.");
            Console.WriteLine("Please call him.");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("");
            Console.WriteLine("That's right.  You were supposed to call your friend Alex for directions...");
            Console.ReadKey();
            Console.WriteLine("Directions?");
            Console.ReadKey();
            Console.WriteLine("What did you need directions for?  Where were you going?");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("Your headache worsens when you try to think back.");
            Console.WriteLine("Instead you focus your attention on the text from a contact called Charon.");

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("It reads:");

            Console.ForegroundColor = ConsoleColor.Green;

            string follow = @"

  █████▒▒█████   ██▓     ██▓     ▒█████   █     █░   ▄▄▄█████▓ ██░ ██ ▓█████                          
▓██   ▒▒██▒  ██▒▓██▒    ▓██▒    ▒██▒  ██▒▓█░ █ ░█░   ▓  ██▒ ▓▒▓██░ ██▒▓█   ▀                          
▒████ ░▒██░  ██▒▒██░    ▒██░    ▒██░  ██▒▒█░ █ ░█    ▒ ▓██░ ▒░▒██▀▀██░▒███                            
░▓█▒  ░▒██   ██░▒██░    ▒██░    ▒██   ██░░█░ █ ░█    ░ ▓██▓ ░ ░▓█ ░██ ▒▓█  ▄                          
░▒█░   ░ ████▓▒░░██████▒░██████▒░ ████▓▒░░░██▒██▓      ▒██▒ ░ ░▓█▒░██▓░▒████▒                         
 ▒ ░   ░ ▒░▒░▒░ ░ ▒░▓  ░░ ▒░▓  ░░ ▒░▒░▒░ ░ ▓░▒ ▒       ▒ ░░    ▒ ░░▒░▒░░ ▒░ ░                         
 ░       ░ ▒ ▒░ ░ ░ ▒  ░░ ░ ▒  ░  ░ ▒ ▒░   ▒ ░ ░         ░     ▒ ░▒░ ░ ░ ░  ░                         
 ░ ░   ░ ░ ░ ▒    ░ ░     ░ ░   ░ ░ ░ ▒    ░   ░       ░       ░  ░░ ░   ░                            
           ░ ░      ░  ░    ░  ░    ░ ░      ░                 ░  ░  ░   ░  ░                         
                                                                                                      
           ██████ ▓█████▄▄▄█████▓▄▄▄█████▓ ██▓ ███▄    █   ▄████      ██████  █    ██  ███▄    █      
         ▒██    ▒ ▓█   ▀▓  ██▒ ▓▒▓  ██▒ ▓▒▓██▒ ██ ▀█   █  ██▒ ▀█▒   ▒██    ▒  ██  ▓██▒ ██ ▀█   █      
         ░ ▓██▄   ▒███  ▒ ▓██░ ▒░▒ ▓██░ ▒░▒██▒▓██  ▀█ ██▒▒██░▄▄▄░   ░ ▓██▄   ▓██  ▒██░▓██  ▀█ ██▒     
           ▒   ██▒▒▓█  ▄░ ▓██▓ ░ ░ ▓██▓ ░ ░██░▓██▒  ▐▌██▒░▓█  ██▓     ▒   ██▒▓▓█  ░██░▓██▒  ▐▌██▒     
         ▒██████▒▒░▒████▒ ▒██▒ ░   ▒██▒ ░ ░██░▒██░   ▓██░░▒▓███▀▒   ▒██████▒▒▒▒█████▓ ▒██░   ▓██░ ██▓ 
         ▒ ▒▓▒ ▒ ░░░ ▒░ ░ ▒ ░░     ▒ ░░   ░▓  ░ ▒░   ▒ ▒  ░▒   ▒    ▒ ▒▓▒ ▒ ░░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒  ▒▓▒ 
         ░ ░▒  ░ ░ ░ ░  ░   ░        ░     ▒ ░░ ░░   ░ ▒░  ░   ░    ░ ░▒  ░ ░░░▒░ ░ ░ ░ ░░   ░ ▒░ ░▒  
         ░  ░  ░     ░    ░        ░       ▒ ░   ░   ░ ░ ░ ░   ░    ░  ░  ░   ░░░ ░ ░    ░   ░ ░  ░   
               ░     ░  ░                  ░           ░       ░          ░     ░              ░   ░  
                                                                                                   ░  
            ";

            Console.WriteLine(follow);

            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("Thats...");
            Console.ReadKey();
            Console.WriteLine("Weird.");
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("You look up at the sky again.");
            Console.WriteLine("It seems like the direction of the setting sun seems to line up with the direction of the road you were originally traveling.");
            Console.WriteLine("");
            Console.ReadKey();
            Console.WriteLine("You look back at the way you supposedly came from, then back down the road toward where you were headed.");
            Console.WriteLine("Your car is completely destroyed, you have no signal.");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("You'll have to make a choice.");
            Console.ReadKey();

            FirstChoice();
        }

        static void FirstChoice()
        {
            string choice1 = "";

            Console.WriteLine("");
            Console.WriteLine("Which way would you like to go?");
            Console.WriteLine("a. Toward the setting sun.");
            Console.WriteLine("b. Away from the setting sun.");
            Console.WriteLine("");
            Console.WriteLine("Please enter a or b.");

            choice1 = Console.ReadLine();

            while (choice1 != "a")
            {
                if (choice1 != "b")
                {
                    Console.WriteLine("You have entered {0}, this is not a possible choice.  Please choose a or b.");
                    choice1 = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("You have chosen to walk into the darkness.");
                    Console.ReadKey();

                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("You start your journey down the road, walking toward the direction you were coming from.");
                    Console.WriteLine("");
                    Console.ReadKey();

                    Console.WriteLine("You walk.");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("And walk...");

                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("And walk...");
                    Console.ReadKey();

                    Console.WriteLine("");
                    Console.WriteLine("And walk.");

                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("You walk for over three hours.  Your throat is dry.");
                    Console.WriteLine("The sky is dark.  You use the flashlight on your phone to illuminate your path.");

                    Console.ReadKey();
                    Console.WriteLine("You stop for a moment to breath.");
                    Console.WriteLine("");
                    Console.ReadKey();

                    Console.WriteLine("...");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("What was that?");
                    Console.ReadKey();

                    Console.WriteLine("");
                    Console.WriteLine("It almost sounded like...");
                    Console.ReadKey();
                    Console.Clear();

                    string crack = @"
 ▄████████    ▄████████    ▄████████  ▄████████    ▄█   ▄█▄ 
███    ███   ███    ███   ███    ███ ███    ███   ███ ▄███▀ 
███    █▀    ███    ███   ███    ███ ███    █▀    ███▐██▀   
███         ▄███▄▄▄▄██▀   ███    ███ ███         ▄█████▀    
███        ▀▀███▀▀▀▀▀   ▀███████████ ███        ▀▀█████▄    
███    █▄  ▀███████████   ███    ███ ███    █▄    ███▐██▄   
███    ███   ███    ███   ███    ███ ███    ███   ███ ▀███▄ 
████████▀    ███    ███   ███    █▀  ████████▀    ███   ▀█▀ 
             ███    ███                           ▀         
                    ";

                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("");
                    Console.WriteLine(crack);

                    Console.ReadKey();

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    Console.WriteLine("What the--");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("Before you can finish your thought something darts in front of your field of vision.");
                    Console.ReadKey();
                    Console.WriteLine("As fast as you can, you shine your cellphone's flashlight on the shadow infront of you.");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.Red;

                    string face = @"
    ⣿⣿⣿⡉⢀⣾⣿⡟⣩⣭⣭⡈⠙⢿⣿⣿⣿⣿⣿⡿⣻⣿⣿⣿⣿⣿⣿⣿⡇⠄ 
    ⣿⣿⡗⠄⣼⣿⣿⢸⡿⠉⠉⢻⡆⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⢠⠄ 
    ⣿⡻⠁⢠⣿⣿⣿⣦⡛⠢⠴⠛⠁⣸⣿⣿⣿⣿⡿⠛⢉⣉⣉⡙⢻⣿⣿⣗⠄⠄ 
    ⠷⠁⠄⢰⣿⣿⣿⣷⣬⣭⣼⣷⣿⣿⣿⣿⣿⡏⢀⣾⠟⠛⢿⣿⣄⣿⣿⡏⠄⠄ 
    ⠄⠄⠄⢹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠄⠳⢀⣀⡼⢟⣼⣿⡟⠄⠄⠄ 
    ⠄⠄⠄⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣮⣒⣲⣶⣾⣿⣿⠏⠄⠄⠄⢠ 
    ⠄⠄⠄⠸⣿⣽⣿⣿⣿⣿⣉⣿⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠁⠄⠄⠄⢠⣷ 
    ⠄⠄⠄⠄⢻⣷⢻⣿⣿⣿⣿⣿⣷⣿⣿⣿⣿⣿⣿⣿⣿⠏⠄⠄⠄⠄⠄⢀⣾⣿ 
    ⠄⠄⠄⠄⠄⢻⣧⡙⢿⣿⣿⣿⣿⣿⡿⣿⣿⣿⠿⠛⠁⠄⠄⠄⠄⠄⢠⣿⣿⣿ 
    ⠄⠄⠄⡀⠄⠈⣿⣿⣶⣭⣭⣭⣿⣾⡿⠟⠋⠁⠄⠄⠄⠄⠄⠄⠄⢠⣿⣿⣿⣿ 
    ⠄⠄⠎⠄⠄⣨⣿⣿⣿⣿⣿⣿⠋⠁⠄⠄⠄⠄⠄⠄⠄⠄⠄⣀⡲⣿⣿⣿⣿⣿
                    ";
                    Console.WriteLine(face);

                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("");

                    Console.WriteLine("The figure is massive.");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("It lunges.");
                    Console.ReadKey();
                    Console.Clear();

                    EndGame firstend = new EndGame();
                    firstend.Dead(Inventory);
                }
            }


        }


    }
}
