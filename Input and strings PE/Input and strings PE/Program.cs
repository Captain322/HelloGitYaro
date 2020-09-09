using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_and_strings_PE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter your pet's name: ");
            string PetName = Console.ReadLine();

            Console.WriteLine("Enter your country of origin: ");
            string Country = Console.ReadLine();

            Console.WriteLine("Enter your favorite color: ");
            string Color = Console.ReadLine();

            Console.WriteLine("Your name has " + (Name.Length) + " characters");

            Console.WriteLine("Your name is " + ((Name.Length) - (PetName.Length)) + " character longer than your pet's name");

            Console.WriteLine("So you're gonna tell me that your " + Color + " pet " + PetName + " was born in " + Country + "?");

            Console.WriteLine("You know, your name in French would probably be spelled " + (Name.ToUpper()[0] + PetName.Substring(0,2) + Country.Substring(0,2) + Color.Substring(0,2)));
        }
    }
}
