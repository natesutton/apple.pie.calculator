using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apple.pie.calculator.Interfaces;

namespace apple.pie.calculator
{
    class AppleCalculatorFactory
    {
        public static IApple objectSelector(int numberofCups, string type)
        {
            if (type == "McIntosh")
            { return new McIntosh(numberofCups); }

            else if (type == "GoldenDelicious")
            { return new GoldenDelicious(numberofCups); }

            else if (type == "Cortland")
            { return new Cortland(numberofCups); }

            else
            { return new Cortland(0); }

        }

    }
}
