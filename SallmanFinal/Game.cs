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
        static double weapon2;

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
                else if (beginGame != "y" && beginGame != "n")
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
                else if (viewStats != "y" && viewStats != "n")
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
                if (choice1 != "b" && choice1 != "a")
                {
                    Console.WriteLine("You have entered {0}, this is not a possible choice.  Please choose a or b.", choice1);
                    choice1 = Console.ReadLine();
                }
                else if (choice1 == "b")
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
        ███████████████████████████████████
        ███████████████████████████████████
        ███████████████████████████████████
        █████████████▒▒▒▒▒▒▒▒▒█████████████
        █████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█████████
        ███████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒███████
        ██████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██████
        █████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█████
        █████▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒█████
        ████▒▒▒▒███▒▒▒▒▒▒▒▒▒▒▒▒▒███▒▒▒▒████
        ███▒▒▒▒██████▒▒▒▒▒▒▒▒▒██████▒▒▒▒███
        ███▒▒▒███▐▀███▒▒▒▒▒▒▒███▀▌███▒▒▒███
        ███▒▒▒██▄▐▌▄███▒▒▒▒▒███▄▐▌▄██▒▒▒███
        ███▒▒▒▒██▌███▒▒▒█▒█▒▒▒███▐██▒▒▒▒███
        ██▒▒▒▒▒▒███▒▒▒▒██▒██▒▒▒▒███▒▒▒▒▒▒██
        █▒▒▒▒▒▒▒▒█▒▒▒▒██▒▒▒██▒▒▒▒█▒▒▒▒▒▒▒▒█
        █▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒█
        █▒▒▒▒█▒▒█▒▒▒▒██▒▒▒▒▒██▒▒▒▒█▒▒█▒▒▒▒█
        ██▒▒▒█▒▒█▒▒▒▒█▒██▒██▒█▒▒▒▒█▒▒█▒▒▒██
        ███▒█▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒█▒███
        █████▒▒█▒▒▒▐███████████▌▒▒▒█▒▒█████
        ███████▒▒▒▐█▀██▀███▀██▀█▌▒▒▒███████
        ███████▒▒▒▒█▐██▐███▌██▌█▒▒▒▒███████
        ███████▒▒▒▒▒▐▒▒▐▒▒▒▌▒▒▌▒▒▒▒▒███████
        ████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████
        ████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████
        █████████▒▒█▒█▒▒▒█▒▒▒█▒█▒▒█████████
        █████████▒██▒█▒▒▒█▒▒▒█▒██▒█████████
        ██████████████▒▒███▒▒██████████████
        ██████████████▒█████▒██████████████
        ███████████████████████████████████
        ███████████████████████████████████
                    ";
                    Console.WriteLine(face);

                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.White;
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

            Console.WriteLine("");
            Console.WriteLine("You decide to trust the ominous text.");
            Console.ReadKey();

            FirstFight();


        }

        static void FirstFight()
        {
            string choice2;

            Console.WriteLine("");
            Console.WriteLine("You walk for what feels like days, although the clock on your phone says it's only one hour.");
            Console.WriteLine("The path in front of you seems to stretch in to infinity.");
            Console.WriteLine("The sky above is streaked with deep blues and purples.");
            Console.WriteLine("The trees around you feel like they're getting closer to you with each step you take.");
            Console.WriteLine("You're starting to feel awfully claustrophobic.");
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("You use the flashlight on your cellphone to light up the path in front of you.");
            Console.WriteLine("You're mildly worried about the battery life, but you'd rather not go walking around in the dark.");
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("You stop for a moment to catch your breath.");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("Perhaps it was the first time you heard it.");
            Console.WriteLine("Perhaps it had always been there, covered up by the sound of your footsteps.");
            Console.ReadKey();

            string rustle = @"
                _   _                                
 _ __ _   _ ___| |_| | ___                           
| '__| | | / __| __| |/ _ \                          
| |  | |_| \__ \ |_| |  __/                          
|_|   \__,_|___/\__|_|\___|                          
                                                     
                             _   _                   
              _ __ _   _ ___| |_| | ___              
             | '__| | | / __| __| |/ _ \             
             | |  | |_| \__ \ |_| |  __/             
             |_|   \__,_|___/\__|_|\___|             
                                                     
                                          _   _      
                           _ __ _   _ ___| |_| | ___ 
                          | '__| | | / __| __| |/ _ \
                          | |  | |_| \__ \ |_| |  __/
                          |_|   \__,_|___/\__|_|\___|
                                                     
            ";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Clear();
            Console.WriteLine(rustle);
            Console.ReadKey();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("");
            Console.WriteLine("There's a noise coming from the tree line directly to your right.");
            Console.ReadKey();
            Console.WriteLine("You feel a shiver creep up your spine as your imagination runs wild.");
            Console.WriteLine("What could be in there?  A fox?  A bear?  Worse?");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("You don't really want to find out what is making the sound,");
            Console.WriteLine("but at the same time you feel a creeping desire to face your fears.");
            Console.WriteLine("");
            Console.ReadKey();

            Console.WriteLine("What will you do?");
            Console.WriteLine("");
            Console.WriteLine("a. Investigate the sound immediately.");
            Console.WriteLine("b. Search on the left side of the path for a weapon.");
            Console.WriteLine("c. Continue on, ignoring the noise.");
            Console.WriteLine("");

            Stats skill1 = new Stats();
            bool skill2 = skill1.SkillCheck(1,6);

            if (skill2 == true)
            {
                Console.WriteLine("You have a feeling searching for a weapon would be your best option.");
            }

            Console.WriteLine("");
            Console.WriteLine("Please enter a, b, or c to continue.");

            choice2 = Console.ReadLine();

            while(choice2 != "b")
            {
                if(choice2 != "a" && choice2 != "c")
                {
                    Console.WriteLine("Please enter a, b, or c to continue.");
                    choice2 = Console.ReadLine();
                }else if(choice2 == "a")
                {
                    Console.WriteLine("");
                    Console.WriteLine("You choose to investigate the sound immediately.");
                    Console.ReadKey();
                    Console.WriteLine("You approach the towering trees with hesitation, feeling yourself grow more apprehensive with each step.");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("The sounds increase as you draw nearer.");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("You lean forward at the edge of the path, the light of your flashlight is swallowed up by the dense forest.");
                    Console.WriteLine("");
                    Console.ReadKey();
                    Console.WriteLine("...");
                    Console.WriteLine("");
                    Console.ReadKey();
                    Console.WriteLine("...");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("You lean in closer, straining your eyes to see something.  Anything.");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("...");
                    Console.ReadKey();

                    string snap = @"
.|'''|  '||\   ||`      /.\      '||'''|, 
||       ||\\  ||      // \\      ||   || 
`|'''|,  || \\ ||     //...\\     ||...|' 
 .   ||  ||  \\||    //     \\    ||      
 |...|' .||   \||. .//       \\. .||      
                                          
                                          
                    ";

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(snap);

                    Console.ReadKey();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");

                    Console.WriteLine("Suddenly, as if out of nowhere, a hulking figure rushes toward you.");
                    Console.WriteLine("Illuminated by your pitiful cellphone's light, it's grotesque face is all too visible.");

                    Console.ReadKey();
                    Monster monster1 = new Monster();
                    monster1.Flash();
                    Console.ForegroundColor = ConsoleColor.White;

                    EndGame secondend = new EndGame();
                    secondend.Dead(Inventory);

                

                }

                Console.WriteLine("");
                Console.WriteLine("You rush over to the trees on your left, using your cellphone's flashlight to search for some kind of weapon.");
                Console.WriteLine("");
                Console.ReadKey();

                double weapon1 = Items.Weapon();
                weapon2 = weapon1;

                if(weapon1 == 1)
                {
                    Console.WriteLine("You have acquired a large rock.");
                    Inventory.Add("Large rock");

                }
                else if(weapon1 == 2)
                {
                    Console.WriteLine("You have acquired a large branch.");
                    Inventory.Add("Large branch");

                }else if(weapon1 == 3)
                {
                    Console.WriteLine("You have acquired a sharp stone.");
                    Inventory.Add("Sharp stone");
                }else if(weapon1 == 4)
                {
                    Console.WriteLine("You have acquired a sharp stick");
                    Inventory.Add("Sharp stick");
                }

                Console.WriteLine("");
                Console.ReadKey();
                Console.WriteLine("Would you like to equip your new weapon?  Enter y for yes, n for no.");
                string equip = Console.ReadLine();

                while(equip != "y" && equip != "n")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please enter y for yes, n for no.");
                    equip = Console.ReadLine();
                }

                if(equip == "y")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Weapon equiped.");
                }else if(equip == "n")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Weapon was not equipped, added to inventory instead.");
                }
                Console.ReadKey();

                Console.WriteLine("");
                Console.WriteLine("With a newfound confidence you approach the right side of the path.");
                Console.WriteLine("");
                Console.ReadKey();
                Console.WriteLine("The rustling seems to have died down.");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("...");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("You're about to turn around when suddenly--");
                Console.ReadKey();

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;

                Monster monster2 = new Monster();
                monster2.Flash();

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("");
                Console.WriteLine("A hulking, hunched figure rushes toward you.  In a panic you drop your cellphone.");
                Console.WriteLine("It skitters helplessly out of reach, sending your immediate surroundings in to darkness.");
                Console.ReadKey();

                Console.WriteLine("");
                Console.WriteLine("All is silent.  You steady yourself, ready to attack should the monster move again.");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("...");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("...");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("...");

                Console.ReadKey();

                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("THERE!");
                Console.ReadKey();

                Console.WriteLine("");
                
                if(equip == "y")
                {
                    if(weapon1 == 1)
                    {
                        Console.WriteLine("You hurl the large rock at the beast as hard as you can, praying your throw connects.");

                        Monster monsterattack = new Monster();
                        bool attackAnswer = monsterattack.Attack(weapon1);
                        if (attackAnswer)
                        {
                            Console.WriteLine("Your aim was true.  The beast screeches in pain and retreats for the time being.");
                        }
                        else
                        {
                            EndGame monsterDeath = new EndGame();
                            monsterDeath.Dead(Inventory);
                        }

                    }
                    else if(weapon1 == 2)
                    {
                        Console.WriteLine("Putting all your force behind your attack, you swing your large branch like a baseball bat.");

                        Monster monsterattack = new Monster();
                        bool attackAnswer = monsterattack.Attack(weapon1);
                        if (attackAnswer)
                        {
                            Console.WriteLine("Your aim was true.  The beast screeches in pain and retreats for the time being.");
                        }
                        else
                        {
                            EndGame monsterDeath = new EndGame();
                            monsterDeath.Dead(Inventory);
                        }

                    }
                    else if(weapon1 == 3)
                    {
                        Console.WriteLine("Wielding the sharp stone like a knife you slash forward, hoping to cut deep in the beast.");

                        Monster monsterattack = new Monster();
                        bool attackAnswer = monsterattack.Attack(weapon1);
                        if (attackAnswer)
                        {
                            Console.WriteLine("Your aim was true.  The beast screeches in pain and retreats for the time being.");
                        }
                        else
                        {
                            EndGame monsterDeath = new EndGame();
                            monsterDeath.Dead(Inventory);
                        }

                    }
                    else if(weapon1 == 4)
                    {
                        Console.WriteLine("Using your sharp stick you lunge forward, hoping to spear the creature through.");

                        Monster monsterattack = new Monster();
                        bool attackAnswer = monsterattack.Attack(weapon1);
                        if (attackAnswer)
                        {
                            Console.WriteLine("Your aim was true.  The beast screeches in pain and retreats for the time being.");
                        }
                        else
                        {
                            EndGame monsterDeath = new EndGame();
                            monsterDeath.Dead(Inventory);
                        }

                    }
                }else if(equip == "n"){
                    Monster attack = new Monster();
                    attack.Attack();

                    EndGame ending = new EndGame();
                    ending.Dead(Inventory);
                }

                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("");

                
                Console.WriteLine("Breathing heavily you fumble for your cellphone.");
                Console.WriteLine("Thankfully it doesn't seem to be damaged, but the battery does read 42%.");
                Console.WriteLine("You have to find a way back to civilization.  Fast.");
                Console.WriteLine("Whatever that thing was you're sure it's not going to stay away forever.");

                Console.ReadKey();

                Console.WriteLine("");
                Console.WriteLine("You resume walking at a significantly faster pace than before.");
                Console.WriteLine("You don't know how long you'll be able to keep this pace up,");
                Console.WriteLine("but you have a feeling you got lucky when you hit the beast.");
                Console.WriteLine("You'd rather not try your luck again.");

                Console.ReadKey();

                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("You don't have to walk for long before you are stopped in your tracks.");
                Console.ReadKey();

                Console.WriteLine("In the distance you see something.  It's almost too dark to make out,");
                Console.WriteLine("but in the faint moonlight you can make out a small silhouette.");
                Console.ReadKey();

                Console.WriteLine("");
                Console.WriteLine("...");

                Console.ReadKey();
                Console.WriteLine("You strain your eyes, trying to determine if the figure is the creature you attacked before.");
                Console.ReadKey();
                Console.WriteLine("It seems to be... Growing?");
                Console.ReadKey();
                Console.WriteLine("No, that's not right.");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("It's...");
                Console.ReadKey();

                Console.WriteLine("");
                Console.WriteLine("It's... Coming closer...");

                Console.ReadKey();
                Console.WriteLine("It's coming closer so fast.  It must.... It must be running!");
                Console.ReadKey();


                Charon();

            }

            

        }

        static void Charon()
        {
            Console.WriteLine("");

            Stats skill1 = new Stats();
            bool skill3 = skill1.SkillCheck(1, 6);

            if(skill3 == true)
            {
                Console.WriteLine("You have the strangest feeling that you should wait and see what happens.");
                Console.WriteLine("");
            }

            Console.WriteLine("The figure is coming closer, what will you do?");

            Console.WriteLine("");
            Console.WriteLine("a. Hide in the woods to avoid the figure.");
            Console.WriteLine("b. Remain where you are.");
            Console.WriteLine("Please enter the letter a or b.");
            
            string runTalk = Console.ReadLine();

            while(runTalk != "b")
            {
                if(runTalk != "b" && runTalk != "a")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please enter the letter a or b.");
                    runTalk = Console.ReadLine();
                }else if(runTalk == "a")
                {
                    Console.WriteLine("You dive into the nearby woods and turn off the flashlight on your cellphone.");
                    Console.WriteLine("You push yourself down into the bushes, covering yourself in the foliage.");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("...");
                    Console.ReadKey();
                    Console.WriteLine("...");
                    Console.ReadKey();
                    Console.WriteLine("...");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("You wait for the creature to pass, but nothing happens.");

                    Console.ReadKey();

                    Console.WriteLine("You could have sworn there was a figure running toward you.");
                    Console.WriteLine("Were your eyes just playing tricks on you?");
                    Console.ReadKey();

                    Console.Write("");
                    Console.WriteLine("You hold your breath, listening for any sound.");
                    Console.WriteLine("");
                    Console.ReadKey();
                    Console.WriteLine("...");
                    Console.WriteLine("");
                    Console.ReadKey();
                    Console.WriteLine("...");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("...");
                    Console.ReadKey();

                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Nothing.");
                    Console.ReadKey();

                    string behind = @"
 ▄▄▄▄   ▓█████  ██░ ██  ██▓ ███▄    █ ▓█████▄                        
▓█████▄ ▓█   ▀ ▓██░ ██▒▓██▒ ██ ▀█   █ ▒██▀ ██▌                       
▒██▒ ▄██▒███   ▒██▀▀██░▒██▒▓██  ▀█ ██▒░██   █▌                       
▒██░█▀  ▒▓█  ▄ ░▓█ ░██ ░██░▓██▒  ▐▌██▒░▓█▄   ▌                       
░▓█  ▀█▓░▒████▒░▓█▒░██▓░██░▒██░   ▓██░░▒████▓                        
░▒▓███▀▒░░ ▒░ ░ ▒ ░░▒░▒░▓  ░ ▒░   ▒ ▒  ▒▒▓  ▒                        
▒░▒   ░  ░ ░  ░ ▒ ░▒░ ░ ▒ ░░ ░░   ░ ▒░ ░ ▒  ▒                        
 ░    ░    ░    ░  ░░ ░ ▒ ░   ░   ░ ░  ░ ░  ░                        
 ░         ░  ░ ░  ░  ░ ░           ░    ░                           
      ░                                ░                             
                                          ▓██   ██▓ ▒█████   █    ██ 
                                           ▒██  ██▒▒██▒  ██▒ ██  ▓██▒
                                            ▒██ ██░▒██░  ██▒▓██  ▒██░
                                            ░ ▐██▓░▒██   ██░▓▓█  ░██░
                                            ░ ██▒▓░░ ████▓▒░▒▒█████▓ 
                                             ██▒▒▒ ░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ 
                                           ▓██ ░▒░   ░ ▒ ▒░ ░░▒░ ░ ░ 
                                           ▒ ▒ ░░  ░ ░ ░ ▒   ░░░ ░ ░ 
                                           ░ ░         ░ ░     ░     
                                           ░ ░                       
                    ";

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(behind);

                    Console.ReadKey();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;

                    EndGame death = new EndGame();
                    death.Charon(Inventory);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("You decide to remain on the path, although your shaking legs scream at you to do otherwise.");
            Console.WriteLine("");
            Console.ReadKey();
            Console.WriteLine("You can see it getting closer.  It's not quite close enough to see with your flashlight,");
            Console.WriteLine("but the sight of it still makes your blood run cold.");
            Console.WriteLine("");
            Console.ReadKey();
            Console.WriteLine("It's clearly not human, the way it moves is too erratic, frantic.");
            Console.WriteLine("");
            Console.ReadKey();
            Console.WriteLine("It seems to be larger than a normal human too, although not as large as the creature you delt with before.");
            Console.WriteLine("");
            Console.ReadKey();

            Console.WriteLine("It almost looks like...");
            Console.WriteLine("");
            Console.ReadKey();
            Console.WriteLine("Like it's legs are on backwards?");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("The creature is getting close now.");
            Console.ReadKey();
            Console.WriteLine("You can almost...");
            Console.WriteLine("");
            Console.WriteLine("Almost see it...");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("Almost...");

            string welcome = @"
 █     █░▓█████  ██▓     ▄████▄   ▒█████   ███▄ ▄███▓▓█████ 
▓█░ █ ░█░▓█   ▀ ▓██▒    ▒██▀ ▀█  ▒██▒  ██▒▓██▒▀█▀ ██▒▓█   ▀ 
▒█░ █ ░█ ▒███   ▒██░    ▒▓█    ▄ ▒██░  ██▒▓██    ▓██░▒███   
░█░ █ ░█ ▒▓█  ▄ ▒██░    ▒▓▓▄ ▄██▒▒██   ██░▒██    ▒██ ▒▓█  ▄ 
░░██▒██▓ ░▒████▒░██████▒▒ ▓███▀ ░░ ████▓▒░▒██▒   ░██▒░▒████▒
░ ▓░▒ ▒  ░░ ▒░ ░░ ▒░▓  ░░ ░▒ ▒  ░░ ▒░▒░▒░ ░ ▒░   ░  ░░░ ▒░ ░
  ▒ ░ ░   ░ ░  ░░ ░ ▒  ░  ░  ▒     ░ ▒ ▒░ ░  ░      ░ ░ ░  ░
  ░   ░     ░     ░ ░   ░        ░ ░ ░ ▒  ░      ░      ░   
    ░       ░  ░    ░  ░░ ░          ░ ░         ░      ░  ░
                        ░                                   
                                        
            ";

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");

            Console.WriteLine(welcome);

            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("");
            Console.WriteLine("It's voice is like nails on a chalkboard.");
            Console.WriteLine("You want to look away but you can't.");
            Console.WriteLine("You don't think it's mouth was even moving.");

            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("You don't know what to call the thing standing just at the edge of your flashlight's beam.");
            Console.WriteLine("It's features were clearly meant to be human, but it's...");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("Wrong.");

            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("It's legs, although covered in human skin, look like they've been stretch over the skeleton of a horse's back legs.");
            Console.WriteLine("It's arms, whittled down to the bone and jutting out of it's torso, or at least the open ribcage that once was it's torso.");
            Console.WriteLine("It's face, twisted up toward the sky, mouth agape as though it were silently bemoaning it's very abominable existance.");
            Console.WriteLine("What a grotesque simulacrum of the human visage.");
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("Your wretch, body heaving at the sight of the impossible, the incomprehensible.");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("It does not move, and for that you are thankful.");
            Console.WriteLine("But it's voice, the grating sound of a dentist's drill to the skull.");
            Console.ReadKey();

            string follow = @"
  █████▒▒█████   ██▓     ██▓     ▒█████   █     █░    ███▄ ▄███▓▓█████ 
▓██   ▒▒██▒  ██▒▓██▒    ▓██▒    ▒██▒  ██▒▓█░ █ ░█░   ▓██▒▀█▀ ██▒▓█   ▀ 
▒████ ░▒██░  ██▒▒██░    ▒██░    ▒██░  ██▒▒█░ █ ░█    ▓██    ▓██░▒███   
░▓█▒  ░▒██   ██░▒██░    ▒██░    ▒██   ██░░█░ █ ░█    ▒██    ▒██ ▒▓█  ▄ 
░▒█░   ░ ████▓▒░░██████▒░██████▒░ ████▓▒░░░██▒██▓    ▒██▒   ░██▒░▒████▒
 ▒ ░   ░ ▒░▒░▒░ ░ ▒░▓  ░░ ▒░▓  ░░ ▒░▒░▒░ ░ ▓░▒ ▒     ░ ▒░   ░  ░░░ ▒░ ░
 ░       ░ ▒ ▒░ ░ ░ ▒  ░░ ░ ▒  ░  ░ ▒ ▒░   ▒ ░ ░     ░  ░      ░ ░ ░  ░
 ░ ░   ░ ░ ░ ▒    ░ ░     ░ ░   ░ ░ ░ ▒    ░   ░     ░      ░      ░   
           ░ ░      ░  ░    ░  ░    ░ ░      ░              ░      ░  ░
                                                                       
            ";

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(follow);

            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("Fear grips you as it speaks, although the abomination remains still as a statue.");

            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("...");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("You must make a choice.");
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("a. Follow");
            Console.WriteLine("b. Follow");

            Console.WriteLine("");
            Console.WriteLine("That's...  That's funny, you could have sworn you had another choice.");

            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("a. Follow");
            Console.WriteLine("b. Fight");

            Console.WriteLine("");
            Console.WriteLine("Yes, that's right, you have a choice.");

            Console.WriteLine("Please choose a or b.");
            string followCharon = Console.ReadLine();


            while(followCharon != "a")
            {
                if(followCharon != "b")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Sorry, you must make a choice.");
                    followCharon = Console.ReadLine();

                }else if(followCharon == "b")
                {
                    Console.WriteLine("");
                    Console.WriteLine("You refuse to look at this creature anymore, you attack without a second thought.");

                    Monster charon = new Monster();
                    bool charon1 = charon.Attack(weapon2, 2);

                    if (charon1)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("The grim mockery of the human form falls to the ground, it's body twitching and convulsing.");
                        Console.ReadKey();
                        Console.WriteLine("You're not sure how you managed to find the strength, but you feel triumphant.");
                        Console.ReadKey();
                        Console.WriteLine("");
                        Console.WriteLine("You step over the twitching corpse gingerly, making sure not to let it's vibrant green blood touch you.");
                        Console.ReadKey();
                    }
                }
            }

        }

    }
}
