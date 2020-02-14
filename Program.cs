using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donohue_PA2
{
    class Program
    {
        static void Main(string[] args)
        {

            string title = "Donohue's Lemonade Stand Inventory System";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title); //code used to center my text at the beginning 

            int lemon;
            int gallon;
            double sugar;


            Console.Write("Enter the number of lemons in stock: ");
            bool parseOkay = int.TryParse(Console.ReadLine(), out lemon);
            if (parseOkay == false || lemon < 0) //if false, console closes 
            {
                Console.WriteLine("Invalid number of lemons. Goodbye.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                return;
            }

            Console.Write("How many cups of sugar are in stock: ");
            bool parseOkay2 = double.TryParse(Console.ReadLine(), out sugar);
            if (parseOkay2 == false || sugar < 0) //if false console closes
            {
                Console.WriteLine("Invalid number of sugar. Goodbye.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                return;
            }

            Console.Write("How many gallons of lemonade do you wish to make: ");
            bool parseOkay3 = int.TryParse(Console.ReadLine(), out gallon);
            if (parseOkay3 == false || gallon < 0) //if false console closes
            {
                Console.WriteLine("Invalid number of gallons. Goodbye.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                return;
            }

            int reqlem = (3 * gallon) - lemon;
            double reqsug = (0.75 * gallon) - sugar; //formulas 

            Console.WriteLine("\nTo make {0} gallons of lemonade you need to order: ", gallon);
            if (lemon >= reqlem || lemon <= 0) //if this is true no more lemons are needed
            {
                Console.Write("> No additional lemons needed");
            }
            else if (lemon <= reqlem || lemon >= 0) //if this is true lemons are needed
            {
                Console.Write("> {0} more lemons", reqlem);
            }

            if (sugar >= reqsug || sugar <= 0)
            {

                Console.Write("\n> No additional sugar needed.");
            }
            else if (sugar <= reqsug || sugar >= 0)
            {
                Console.Write("\n> {0:f} cups of sugar", reqsug);
            }

            if (lemon <= reqlem && sugar >= reqsug)
            {
                double total1 = (reqlem * 0.45);
                Console.Write("\n\nThese ingredients will cost {0:c}", total1);
            }
            else if (lemon >= reqlem && sugar >= reqsug) // required lemon cost
            {
                double tot = 0;
                Console.Write("\n\nThese ingredients will cost {0:c}", tot);
            }

            else if (sugar <= reqsug && lemon >= reqlem) //required sugar cost 
            {
                double total2 = (reqsug * 1.05);
                Console.Write("\n\nThese ingredients will cost {0:c}", total2);
            }


            if (lemon <= reqlem && sugar <= reqsug) //both costs combined
            {
                double total = (reqlem * 0.45) + (reqsug * 1.05);
                Console.Write("\n\nThese ingredients will cost: ");
                Console.Write("{0:c}", total);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}

