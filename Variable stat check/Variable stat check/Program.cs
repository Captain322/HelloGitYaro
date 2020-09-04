using System;

namespace Variable_stat_check
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = ("Captain322");
            const int StartingPoints = 50;
            int Strength = StartingPoints / 10 * 2;
            int Dexterity = Strength / 2;
            int Intelligence = 7;
            int Health = Dexterity + Intelligence - 2;
            int Charisma = StartingPoints - Strength - Dexterity - Intelligence - Health;
            int TotalPoints;
            TotalPoints = Strength + Dexterity + Intelligence + Health + Charisma;
            Console.WriteLine("Hello {0}", Name);
            Console.WriteLine("Welcome to the stat checker 2.0");
            Console.WriteLine("Your Strength is {0}", Strength);
            Console.WriteLine("Your Dexterity is {0}", Strength);
            Console.WriteLine("Your Intelligence is {0}", Strength);
            Console.WriteLine("Your Health is {0}", Strength);
            Console.WriteLine("Your Charisma is {0}", Strength);
            Console.WriteLine("Your build is complete, your total number of points is - {0}", + TotalPoints);
        }
    }
}
