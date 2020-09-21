using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_1_Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int AvgOrbitalSpeedMPH = 66616;

            Console.WriteLine("Enter your first name: ");
            var firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            var lastName = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            var ageinput = Console.ReadLine();
            int age = int.Parse(ageinput);

            Console.WriteLine("Hello "+ firstName + " " + lastName + "! I like that name, but I personally prefer " + (firstName.Substring(0,3) + lastName.Substring(3)));

            Console.WriteLine("Your first name is " + (firstName.Length - lastName.Length) + " character/s longer than your last name");

            //the 8760 is the amount of hours in one year

            Console.WriteLine("In your " + age + " years around the sun you have travelled " + (age * 8760 * 66616) + " miles");




        }
    }
}
