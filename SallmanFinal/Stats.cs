using System;
using System.Collections.Generic;
using System.Text;

namespace SallmanFinal
{
    class Stats : Game
    {
        public static int strength = 5;
        public static int intelligence = 5;
        public static int luck = 5;

        

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

        public void ViewStats()
        {
            Console.WriteLine("Strength: {0}", strength);
            Console.WriteLine("Luck: {0}", luck);
            Console.WriteLine("Intelligence: {0}", intelligence);
        }

        public void ResetStats()
        {
            strength = 5;
            intelligence = 5;
            luck = 5;
        }

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
