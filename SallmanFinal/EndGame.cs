using System;
using System.Collections.Generic;
using System.Text;

namespace SallmanFinal
{
    class EndGame: Game
    {

        public void Dead(List<string> Inventory)
        {
            string again; 
            string dead = @"
`8.`8888.      ,8'  ,o888888o.     8 8888      88                    .8.          8 888888888o.   8 8888888888   
 `8.`8888.    ,8'. 8888     `88.   8 8888      88                   .888.         8 8888    `88.  8 8888         
  `8.`8888.  ,8',8 8888       `8b  8 8888      88                  :88888.        8 8888     `88  8 8888         
   `8.`8888.,8' 88 8888        `8b 8 8888      88                 . `88888.       8 8888     ,88  8 8888         
    `8.`88888'  88 8888         88 8 8888      88                .8. `88888.      8 8888.   ,88'  8 888888888888 
     `8. 8888   88 8888         88 8 8888      88               .8`8. `88888.     8 888888888P'   8 8888         
      `8 8888   88 8888        ,8P 8 8888      88              .8' `8. `88888.    8 8888`8b       8 8888         
       8 8888   `8 8888       ,8P  ` 8888     ,8P             .8'   `8. `88888.   8 8888 `8b.     8 8888         
       8 8888    ` 8888     ,88'     8888   ,d8P             .888888888. `88888.  8 8888   `8b.   8 8888         
       8 8888       `8888888P'        `Y88888P'             .8'       `8. `88888. 8 8888     `88. 8 888888888888 
                                                                                                                 
                    8 888888888o.      8 8888888888            .8.          8 888888888o.                        
                    8 8888    `^888.   8 8888                 .888.         8 8888    `^888.                     
                    8 8888        `88. 8 8888                :88888.        8 8888        `88.                   
                    8 8888         `88 8 8888               . `88888.       8 8888         `88                   
                    8 8888          88 8 888888888888      .8. `88888.      8 8888          88                   
                    8 8888          88 8 8888             .8`8. `88888.     8 8888          88                   
                    8 8888         ,88 8 8888            .8' `8. `88888.    8 8888         ,88                   
                    8 8888        ,88' 8 8888           .8'   `8. `88888.   8 8888        ,88'                   
                    8 8888    ,o88P'   8 8888          .888888888. `88888.  8 8888    ,o88P'                     
                    8 888888888P'      8 888888888888 .8'       `8. `88888. 8 888888888P'                        
                    ";


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(dead);
            Console.ReadKey();

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("You have reached an ending.  Unfortunately it is not the best ending.");
            Console.WriteLine("You were attacked by a mysterious creature.");
            Console.WriteLine("");
            Console.WriteLine("Here are the items you found on your journey:");
            foreach (string item in Inventory)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("Thank you for playing.  Would you like to try again?");
            Console.WriteLine("Enter y to start over, n to quit game.");
            again = Console.ReadLine();

            while (again != "y")
            {
                if(again != "n")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please enter y to start over, n to quit the game.");
                    again = Console.ReadLine();
                }
                else
                {
                    Environment.Exit(0);
                    
                }
            }

            Stats reset = new Stats();
            reset.ResetStats();
            StartGame();

        }

        public void BadEnd(List<string> Inventory)
        {
            string again;
            string dead = @"
`8.`8888.      ,8'  ,o888888o.     8 8888      88                    .8.          8 888888888o.   8 8888888888   
 `8.`8888.    ,8'. 8888     `88.   8 8888      88                   .888.         8 8888    `88.  8 8888         
  `8.`8888.  ,8',8 8888       `8b  8 8888      88                  :88888.        8 8888     `88  8 8888         
   `8.`8888.,8' 88 8888        `8b 8 8888      88                 . `88888.       8 8888     ,88  8 8888         
    `8.`88888'  88 8888         88 8 8888      88                .8. `88888.      8 8888.   ,88'  8 888888888888 
     `8. 8888   88 8888         88 8 8888      88               .8`8. `88888.     8 888888888P'   8 8888         
      `8 8888   88 8888        ,8P 8 8888      88              .8' `8. `88888.    8 8888`8b       8 8888         
       8 8888   `8 8888       ,8P  ` 8888     ,8P             .8'   `8. `88888.   8 8888 `8b.     8 8888         
       8 8888    ` 8888     ,88'     8888   ,d8P             .888888888. `88888.  8 8888   `8b.   8 8888         
       8 8888       `8888888P'        `Y88888P'             .8'       `8. `88888. 8 8888     `88. 8 888888888888 
                                                                                                                 
                    8 888888888o.      8 8888888888            .8.          8 888888888o.                        
                    8 8888    `^888.   8 8888                 .888.         8 8888    `^888.                     
                    8 8888        `88. 8 8888                :88888.        8 8888        `88.                   
                    8 8888         `88 8 8888               . `88888.       8 8888         `88                   
                    8 8888          88 8 888888888888      .8. `88888.      8 8888          88                   
                    8 8888          88 8 8888             .8`8. `88888.     8 8888          88                   
                    8 8888         ,88 8 8888            .8' `8. `88888.    8 8888         ,88                   
                    8 8888        ,88' 8 8888           .8'   `8. `88888.   8 8888        ,88'                   
                    8 8888    ,o88P'   8 8888          .888888888. `88888.  8 8888    ,o88P'                     
                    8 888888888P'      8 888888888888 .8'       `8. `88888. 8 888888888P'                        
                    ";


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(dead);
            Console.ReadKey();

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("This... Doesn't seem right.  You're dead?");
            Console.WriteLine("Nothing attacked you.  How could you be dead?");
            Console.WriteLine("Perhaps you should play again for more answers.");
            Console.WriteLine("");
            Console.WriteLine("Here are the items you found on your journey:");
            foreach (string item in Inventory)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("Thank you for playing.  Would you like to try again?");
            Console.WriteLine("Enter y to start over, n to quit game.");
            again = Console.ReadLine();

            while (again != "y")
            {
                if (again != "n")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please enter y to start over, n to quit the game.");
                    again = Console.ReadLine();
                }
                else
                {
                    Environment.Exit(0);

                }
            }

            Stats reset = new Stats();
            reset.ResetStats();
            StartGame();

        }

        public void Charon(List<string> Inventory)
        {
            string again;
            string dead = @"
`8.`8888.      ,8'  ,o888888o.     8 8888      88                    .8.          8 888888888o.   8 8888888888   
 `8.`8888.    ,8'. 8888     `88.   8 8888      88                   .888.         8 8888    `88.  8 8888         
  `8.`8888.  ,8',8 8888       `8b  8 8888      88                  :88888.        8 8888     `88  8 8888         
   `8.`8888.,8' 88 8888        `8b 8 8888      88                 . `88888.       8 8888     ,88  8 8888         
    `8.`88888'  88 8888         88 8 8888      88                .8. `88888.      8 8888.   ,88'  8 888888888888 
     `8. 8888   88 8888         88 8 8888      88               .8`8. `88888.     8 888888888P'   8 8888         
      `8 8888   88 8888        ,8P 8 8888      88              .8' `8. `88888.    8 8888`8b       8 8888         
       8 8888   `8 8888       ,8P  ` 8888     ,8P             .8'   `8. `88888.   8 8888 `8b.     8 8888         
       8 8888    ` 8888     ,88'     8888   ,d8P             .888888888. `88888.  8 8888   `8b.   8 8888         
       8 8888       `8888888P'        `Y88888P'             .8'       `8. `88888. 8 8888     `88. 8 888888888888 
                                                                                                                 
                    8 888888888o.      8 8888888888            .8.          8 888888888o.                        
                    8 8888    `^888.   8 8888                 .888.         8 8888    `^888.                     
                    8 8888        `88. 8 8888                :88888.        8 8888        `88.                   
                    8 8888         `88 8 8888               . `88888.       8 8888         `88                   
                    8 8888          88 8 888888888888      .8. `88888.      8 8888          88                   
                    8 8888          88 8 8888             .8`8. `88888.     8 8888          88                   
                    8 8888         ,88 8 8888            .8' `8. `88888.    8 8888         ,88                   
                    8 8888        ,88' 8 8888           .8'   `8. `88888.   8 8888        ,88'                   
                    8 8888    ,o88P'   8 8888          .888888888. `88888.  8 8888    ,o88P'                     
                    8 888888888P'      8 888888888888 .8'       `8. `88888. 8 888888888P'                        
                    ";


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(dead);
            Console.ReadKey();

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("You have reached an ending.  Unfortunately it is not the best ending.");
            Console.WriteLine("You should have been watching your back.");
            Console.WriteLine("");
            Console.WriteLine("Here are the items you found on your journey:");
            foreach (string item in Inventory)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("Thank you for playing.  Would you like to try again?");
            Console.WriteLine("Enter y to start over, n to quit game.");
            again = Console.ReadLine();

            while (again != "y")
            {
                if (again != "n")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please enter y to start over, n to quit the game.");
                    again = Console.ReadLine();
                }
                else
                {
                    Environment.Exit(0);

                }
            }

            Stats reset = new Stats();
            reset.ResetStats();
            StartGame();

        }


        public void GoodEnd(List<string> Inventory)
        {
            string again;
            string dead = @"
`8.`8888.      ,8'  ,o888888o.     8 8888      88                    .8.          8 888888888o.   8 8888888888   
 `8.`8888.    ,8'. 8888     `88.   8 8888      88                   .888.         8 8888    `88.  8 8888         
  `8.`8888.  ,8',8 8888       `8b  8 8888      88                  :88888.        8 8888     `88  8 8888         
   `8.`8888.,8' 88 8888        `8b 8 8888      88                 . `88888.       8 8888     ,88  8 8888         
    `8.`88888'  88 8888         88 8 8888      88                .8. `88888.      8 8888.   ,88'  8 888888888888 
     `8. 8888   88 8888         88 8 8888      88               .8`8. `88888.     8 888888888P'   8 8888         
      `8 8888   88 8888        ,8P 8 8888      88              .8' `8. `88888.    8 8888`8b       8 8888         
       8 8888   `8 8888       ,8P  ` 8888     ,8P             .8'   `8. `88888.   8 8888 `8b.     8 8888         
       8 8888    ` 8888     ,88'     8888   ,d8P             .888888888. `88888.  8 8888   `8b.   8 8888         
       8 8888       `8888888P'        `Y88888P'             .8'       `8. `88888. 8 8888     `88. 8 888888888888 
                                                                                                                 
                    8 888888888o.      8 8888888888            .8.          8 888888888o.                        
                    8 8888    `^888.   8 8888                 .888.         8 8888    `^888.                     
                    8 8888        `88. 8 8888                :88888.        8 8888        `88.                   
                    8 8888         `88 8 8888               . `88888.       8 8888         `88                   
                    8 8888          88 8 888888888888      .8. `88888.      8 8888          88                   
                    8 8888          88 8 8888             .8`8. `88888.     8 8888          88                   
                    8 8888         ,88 8 8888            .8' `8. `88888.    8 8888         ,88                   
                    8 8888        ,88' 8 8888           .8'   `8. `88888.   8 8888        ,88'                   
                    8 8888    ,o88P'   8 8888          .888888888. `88888.  8 8888    ,o88P'                     
                    8 888888888P'      8 888888888888 .8'       `8. `88888. 8 888888888P'                        
                    ";


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(dead);
            Console.ReadKey();

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("You are dead.  You were always dead.  There was never any other outcome.");
            Console.WriteLine("Charon was able to help your soul cross over to the world of the dead.");
            Console.WriteLine("You suppose this you best case scenario.");
            Console.WriteLine("");
            Console.WriteLine("Congratulations, you have reached the best ending.");
            Console.WriteLine("Here are the items you found on your journey:");
            foreach (string item in Inventory)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("Thank you for playing.  Would you like to try again?");
            Console.WriteLine("Enter y to start over, n to quit game.");
            again = Console.ReadLine();

            while (again != "y")
            {
                if (again != "n")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please enter y to start over, n to quit the game.");
                    again = Console.ReadLine();
                }
                else
                {
                    Environment.Exit(0);

                }
            }

            Stats reset = new Stats();
            reset.ResetStats();
            StartGame();

        }
    }
}
