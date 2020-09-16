using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_PE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name: ");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            string LName = Console.ReadLine();

            Console.WriteLine("Enter your height (in whole inches): ");
            string HeightString = Console.ReadLine();
            int Height = int.Parse(HeightString);

            Console.WriteLine(Math.Max(Name.Length, LName.Length));

            Console.WriteLine(Math.Abs(Name.Length - LName.Length));

            Console.WriteLine("According to your height, you would fit into a circle with an area of " +
                Math.Round((Math.PI * (Height / 2) * (Height / 2))) + 
                " and a circumference of " +
                Math.Round((2 * Math.PI * (Height / 2))));
        }
    }
}
