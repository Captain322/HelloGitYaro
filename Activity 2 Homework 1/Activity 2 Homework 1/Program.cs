using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_2_Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter an adjective: ");
            var adj1 = Console.ReadLine();
            Console.Write("Enter another adjective: ");
            var adj2 = Console.ReadLine();
            Console.Write("Enter one last adjective: ");
            var adj3 = Console.ReadLine();

            Console.Write("Enter an adverb: ");
            var adverb1 = Console.ReadLine();
            Console.Write("Enter another adverb: ");
            var adverb2 = Console.ReadLine();

            Console.Write("Enter a female first name: ");
            var femName = Console.ReadLine();
            Console.Write("Enter any last name: ");
            var lastName = Console.ReadLine();
            Console.Write("Enter a male first name: ");
            var maleName = Console.ReadLine();

            Console.Write("Enter a noun: ");
            var noun1 = Console.ReadLine();
            Console.Write("Enter another noun: ");
            var noun2 = Console.ReadLine();
            Console.Write("Enter one more noun: ");
            var noun3 = Console.ReadLine();
            Console.Write("And maybe just one more noun?: ");
            var noun4 = Console.ReadLine();
            Console.Write("Okay last noun I promise: ");
            var noun5 = Console.ReadLine();

            Console.Write("Enter a body part: ");
            var BodyPart = Console.ReadLine();
            Console.Write("Enter a plural body part: ");
            var pBodyPart = Console.ReadLine();
            Console.Write("Enter a plural article of clothing: ");
            var pClothing = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            var pNoun1 = Console.ReadLine();
            Console.Write("Enter the last and final item - one more plural noun: ");
            var pNoun2 = Console.ReadLine();

            Console.WriteLine("\nNewspaper critics agree that " + maleName + " and " + femName +" is a comedy " + noun1 +" that will knock your " + pClothing +" off. ");

            Console.WriteLine("\"It will tickle your funny {0} !\" - The Washington {1}", BodyPart, noun3);

            Console.WriteLine("\"Two " + pBodyPart + " up!\" - Ebert and " + lastName);

            Console.WriteLine("\"A smart, " + adj1 + " and " + adj2 + " comedy. You not only laugh, but it brings " + pNoun1 + " to your eyes.\" - The New Orleans Times - " + noun3);

            Console.WriteLine("\"A " + adverb1 + " funny half-hour " + noun4 + "; " + adverb2 + " acted by a " + adj3 + " cast of all - star " + pNoun2 + "\" - The Chicago Sun - " + noun5);
        }
    }
}
