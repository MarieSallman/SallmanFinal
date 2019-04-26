using System;
using System.Collections.Generic;
using System.Text;

namespace SallmanFinal
{
    class Stats : Game
    {
        static int strength = 5;
        static int intelligence = 5;
        static int charisma = 5;
        static int luck = 5;

        public void OccupationStats(int occupation) {
            if(occupation == 1)
            {
                Console.WriteLine("Charisma has increased by 3.");
                charisma = 8;
            }else if(occupation == 2)
            {
                Console.WriteLine("Strength has increased by 3.");
                strength = 8;
            }else if(occupation == 3)
            {
                Console.WriteLine("Intellignece has increased by 3.");
                intelligence = 8;
            }else if(occupation == 4)
            {
                Console.WriteLine("Strength, charisma, and intelligence have increased by 1.");
                strength = 6;
                charisma = 6;
                intelligence = 6;
            }
        }

        public void ViewStats()
        {
            Console.WriteLine("Strength: {0}", strength);
            Console.WriteLine("Charisma: {0}", charisma);
            Console.WriteLine("Intelligence: {0}", intelligence);
            Console.WriteLine("Luck: {0}", luck);
        }
    }
}
