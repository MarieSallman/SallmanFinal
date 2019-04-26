using System;
using System.Collections.Generic;
using System.Text;

namespace SallmanFinal
{
    class EndGame
    {

        public void Dead(List<string> Inventory)
        {
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

            Console.WriteLine("");
            Console.WriteLine("You have reached ending A, you were attacked by a mysterious creature.");
            Console.WriteLine("");
            Console.WriteLine("Here are the items you found on your journey:");
            foreach (string item in Inventory)
            {
                Console.WriteLine(item);
            }
        }
    }
}
