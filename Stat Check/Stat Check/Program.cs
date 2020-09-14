using System;

namespace Stat_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            Console.WriteLine("What's your name?");
            Name = Console.ReadLine();
            Console.WriteLine("Hello {0}", Name + " welcome to the stat checker");
            Console.WriteLine("Let's get you some stats - you have 50 points total");
            Console.WriteLine("Current stats: ");
            Console.WriteLine("Strength - " + (50 * 0.2));
            Console.WriteLine("Perception - " + (50 * 0.2 * 0.5));
            Console.WriteLine("Endurance - 7");
            Console.WriteLine("Charisma - " + (5 + 7 - 2));
            Console.WriteLine("Intellegence - " + (50 - 10 - 5 - 7 - 10));
            Console.WriteLine("Press Alt + F4 to re-distribute");

        }
    }
}
