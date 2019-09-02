using System;
using System.IO;
using System.Linq;
using System.Text;
using System;

namespace MonsterInc2Simple
{
    class Program
    {
        public static void Main()
        {
            Console.Clear();
            Program program = new Program();
            Console.WriteLine("==========\nMonster Inc.\n==========\n1.Add a monster\n2.Load all monsters\n3.Delete monsters\n4.Load specific monster");
            program.SwitchStatement();
        }
        void SwitchStatement()
        {
            Monster monster = new Monster();
            string text = Console.ReadLine();
            switch (text)
            {
                case "1":
                    monster.MonsterConstructor();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("This is not accepted, try again");
                    SwitchStatement();
                    break;
            }
        }
    }
    class Monster
    {
        public string hair, eyes, name, special;
        public int id = 0;
        public void MonsterConstructor()
        {
            Name();
            ID();
            long id = ID();
            Hair();
            Eyes();
            Special();
            Console.WriteLine("\nYou have added a monster called {0}\nHair: {1}\nEyes: {2}\nSpecial Abilities: {3}\nID : {4}\nPress any key to continue", name, hair, eyes, special, id);
            Console.ReadKey();
            Program.Main();
        }

        void Hair()
        {
            Console.WriteLine("Please detail the hair");
            hair = Console.ReadLine();
            string path = @"C:\Users\Jez Horton\source\repos\week4\Day1\MonsterInc\MonsterInc2Simple\MonsterHair.Txt";
           /*     // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    string[] createText = { "This is the Monsters Names" };
                    File.WriteAllLines(path, createText, Encoding.UTF8);
                }*/
                // This text is always added, making the file longer over time
                // if it is not deleted.
                string appendText = hair + Environment.NewLine;
         
                File.AppendAllText(path, appendText, Encoding.UTF8);
                // Open the file to read from.
                /*string[] readText = File.ReadAllLines(path, Encoding.UTF8);
                foreach (string s in readText)
                {
                    Console.WriteLine(s);
                }*/
            }
        void Eyes()
        {
            Console.WriteLine("Please detail the Eyes");
            eyes = Console.ReadLine();
            string path = @"C:\Users\Jez Horton\source\repos\week4\Day1\MonsterInc\MonsterInc2Simple\MonsterEyes.Txt";
            string appendText = eyes + Environment.NewLine;
            File.AppendAllText(path, appendText, Encoding.UTF8);
            //string[] readText = File.ReadAllLines(path, Encoding.UTF8);
        }
        void Name()
        {
            Console.WriteLine("Please add the Name");
            name = Console.ReadLine();
            string path = @"C:\Users\Jez Horton\source\repos\week4\Day1\MonsterInc\MonsterInc2Simple\MonsterNames.Txt";
            string appendText = name + Environment.NewLine;
            File.AppendAllText(path, appendText, Encoding.UTF8);
            //string[] readText = File.ReadAllLines(path, Encoding.UTF8);
        }
        long ID()
        {
            string path = @"C:\Users\Jez Horton\source\repos\week4\Day1\MonsterInc\MonsterInc2Simple\MonsterID.Txt";
            var lineCounter = 0L;
            using (var reader = new StreamReader(path))
            {
                while (reader.ReadLine() != null)
                {
                    lineCounter++;
                }
            }
            string appendText = lineCounter + Environment.NewLine;
            File.AppendAllText(path, appendText, Encoding.UTF8);
            return lineCounter;
        }
        void Special()
        {
            Console.WriteLine("Please add the Special ability of the monster");
            special = Console.ReadLine();
            string path = @"C:\Users\Jez Horton\source\repos\week4\Day1\MonsterInc\MonsterInc2Simple\MonsterSpecialAbilities.Txt";
            string appendText = special + Environment.NewLine;
            File.AppendAllText(path, appendText, Encoding.UTF8);
        }
    }
}
