using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apple.pie.calculator.Interfaces;


namespace apple.pie.calculator
{
    public class Cortland : IApple
    {
        private int NumberOfCups { get; set; }

        public Cortland(int numberOfCups)
        {
            NumberOfCups = numberOfCups;
        }
        
        public double GetNumberOfApples()
        {
            return (0.60 * NumberOfCups);

        }
    }
}
