using System;
using System.Collections.Generic;
using System.Text;

namespace SallmanFinal
{
    internal class Items: Game
    {

        
        private static double[] weapons = { 1, 2, 3, 4};
        private static double itemName;

        
        //Method used to give the player a random weapon
        public static double Weapon()
        {
            Random randomNumber = new Random();

            int number = randomNumber.Next(weapons.Length);

            itemName = weapons[number];

            return itemName;
        }
    }
}
