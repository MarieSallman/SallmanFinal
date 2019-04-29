using System;
using System.Collections.Generic;
using System.Text;

namespace SallmanFinal
{
    class Stats : Game
    {

        //Possible character stats, base level 5.
        public static int strength = 5;
        public static int intelligence = 5;
        public static int luck = 5;

        
        //Used to get character background and change the base stats.
        public void OccupationStats(int occupation) {
            if(occupation == 1)
            {
                Console.WriteLine("Luck has increased by 3.");
                luck = 8;
            }else if(occupation == 2)
            {
                Console.WriteLine("Strength has increased by 3.");
                strength = 8;
            }else if(occupation == 3)
            {
                Console.WriteLine("Intelligence has increased by 3.");
                intelligence = 8;
            }else if(occupation == 4)
            {
                Console.WriteLine("Strength, luck, and intelligence have increased by 1.");
                strength = 6;
                luck = 6;
                intelligence = 6;
            }
        }

        //Allows player to view their stats after picking their background.
        public void ViewStats()
        {
            Console.WriteLine("Strength: {0}", strength);
            Console.WriteLine("Luck: {0}", luck);
            Console.WriteLine("Intelligence: {0}", intelligence);
        }


        //Used at a game over, allows for stats to be reset if the player wants to start a new game.
        public void ResetStats()
        {
            strength = 5;
            intelligence = 5;
            luck = 5;
        }


        //The public method for skill checks, returns true if check is passed.
        public bool SkillCheck(int type, int check)
        {

            if(type == 1)
            {
                
                bool intResult = IntelligenceCheck(intelligence, check);
                if (intResult)
                {
                    return true;
                }
                else { return false; }
            }
            else if(type == 2)
            {
                
                bool strResult = StrengthCheck(strength, check);
                if (strResult)
                {
                    return true;
                }
                else { return false; }
            }else if(type == 3)
            {
                
                bool luckResult = LuckCheck(luck, check);
                if (luckResult)
                {
                    return true;
                }
                else { return false; }
            }
            return false;
        }

        //Private method for Intelligence checks
        private bool IntelligenceCheck(int intelligence, int check)
        {
            if(intelligence > check)
            {
                Console.WriteLine("");
                Console.WriteLine("Intelligence check passed.");
                Console.WriteLine("");
                return true;
            }else if(intelligence < check)
            {
                Console.WriteLine("");
                Console.WriteLine("Intelligence check failed.");
                Console.WriteLine("");
                return false;
            }

            return false;
        }


        //Private method for strength checks
        private bool StrengthCheck(int strength, int check)
        {
            if (strength > check)
            {
                Console.WriteLine("");
                Console.WriteLine("Strength check passed.");
                Console.WriteLine("");
                return true;
            }
            else if (strength < check)
            {
                Console.WriteLine("");
                Console.WriteLine("Strength check failed.");
                Console.WriteLine("");
                return false;
            }

            return false;
        }


        //Private method for luck checks
        private bool LuckCheck(int luck, int check)
        {
            if (luck > check)
            {
                Console.WriteLine("");
                Console.WriteLine("Luck check passed.");
                Console.WriteLine("");
                return true;
            }
            else if (luck < check)
            {
                Console.WriteLine("");
                Console.WriteLine("Luck check failed.");
                Console.WriteLine("");
                return false;
            }

            return false;
        }

        
    }
}
