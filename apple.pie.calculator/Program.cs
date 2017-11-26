using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apple.pie.calculator.Interfaces;

namespace apple.pie.calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many cups of of apples does your receipe call for?");
            int cups = Int32.Parse(Console.ReadLine());

            Console.WriteLine("What kind of apples are you using? (possibilties are: McIntosh, GoldenDelicious, and Cortland.)");
            string type = Console.ReadLine();

            // Create an object of type IApple interface and execute static method objectSelector.  The object calls GetNumberOfApples()
            // which is common to each sub class.
            IApple applePieCalculator = AppleCalculatorFactory.objectSelector(cups, type);

            Console.WriteLine("Your apple pie requires {0} cups of {1} apples", Convert.ToString(applePieCalculator.GetNumberOfApples()), type);
            Console.ReadLine();
        }
    }
}
