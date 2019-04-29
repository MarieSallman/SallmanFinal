using System;
using System.Collections.Generic;
using System.Text;

namespace SallmanFinal
{
    class Monster: Stats
    {

        //Method used when player attempts to fight unarmed.
        public void Attack()
        {
            Console.WriteLine("Your feeble attempts to attack the creature with your bare fists are laughable at best.");
            Console.WriteLine("");
            Console.ReadKey();


         
        }
        
        //Attack method used when player has a weapon equipped.
        public bool Attack(double weapon)
        {
            double chance = strength + weapon;

            if(chance >= 6)
            {
                strength++;
                return true;

            }else if(chance < 7)
            {
                return false;
            }
            return false;
        }

        //Again overrides the previous attack method by taking in more parameters, used when player attacks with a weapon but is at a disadvantage.
        public bool Attack(double weapon, double disadvantage)
        {
            double chance = strength + weapon - disadvantage;

            if (chance > 9)
            {
                strength++;
                return true;
            }
            else if (chance <= 9)
            {
                return false;
            }
            return false;
        }


        //Method to simulate a flashing monster image.
        public void Flash()
        {
            string creature = @"
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
            for (int i = 0; i < 50; i++){
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(creature);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(creature);
                Console.Clear();
            }

            Console.Clear();
            return;
            
            
        }



    }
}
