using System;
using System.Collections.Generic;
using System.Text;

namespace SallmanFinal
{
    public class Items
    {
        static double[] weapons = { 1, 2, 3, 4};
        static double itemName;
        static double itemAttack;

        public static double Weapon()
        {
            Random randomNumber = new Random();

            int number = randomNumber.Next(weapons.Length);

            itemName = weapons[number];

            return itemName;
        }
    }
}
