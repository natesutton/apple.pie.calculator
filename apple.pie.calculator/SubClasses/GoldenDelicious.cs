using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apple.pie.calculator.Interfaces;


namespace apple.pie.calculator
{
    public class GoldenDelicious : IApple
    {
        private int NumberOfCups { get; set; }

        public GoldenDelicious(int numberOfCups)
        {
            NumberOfCups = numberOfCups;
        }
        
        public double GetNumberOfApples()
        {
            return (0.75 * NumberOfCups);

        }
    }
}
