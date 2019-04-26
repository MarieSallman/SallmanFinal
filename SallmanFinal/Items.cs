using System;
using System.Collections.Generic;
using System.Text;

namespace SallmanFinal
{
    public class Items
    {
        static string[] Weapons = { "Rock", "Thick branch", "Sharp rock", "Sharp stick"};
        static string[] Attack = { "1", "2", "3", "1" };

        public static void Weapon()
        {
            Random randomNumber = new Random();

            int number = randomNumber.Next(Weapons.Length);
        }
    }
}
