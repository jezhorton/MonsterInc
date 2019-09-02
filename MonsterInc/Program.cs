using System;

using System.Collections.Generic;

namespace MonsterInc
{
    class Program
    {
        new Monster m;
        static void Main(string[] args)
        {
            Console.WriteLine("========================\nWelcome to Monsters Inc\n========================");
        }
        void Selector()
        {
            m = new Monster();
            Console.WriteLine("Would you like to create a monster, return a student or return all students?" +
                "\n1.Create a monster\n2.Return a student\n3.Return all students");
            string entered = Console.ReadLine();
            switch (entered)
            {
                case "1":

                    break;
                case "2":

                    break;
                case "3":

                    break;
                default:

                    break;
            }
        }
    }


    class Monster
    {
        void ID()
        {

        }
        int Total()
        {

        }
        void Eyes()
        {

        }
        void Hair()
        {

        }
        void ScareLevel()
        {
            int Scarelevel(int s)
            {
                int p = Convert.ToInt32(s);
                if (p <= 10)
                {
                    Console.WriteLine("Weak");
                }
                return p; //TO DO : MORE LEVELS
            }
        }
        void SpecialAbility()
        {
            var myDict = new Dictionary<string , int>
        {
            { "Camo", 4 },{ "Large", 4 },
            { "Hairy", 3 },
            { "Smelly", 6},
            { "Spikes", 9 }, //TO DO : MORE ABILITIES
            { "Small", 5 }
        };
        }
    }
}
