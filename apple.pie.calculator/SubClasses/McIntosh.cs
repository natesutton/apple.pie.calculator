using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apple.pie.calculator.Interfaces;


namespace apple.pie.calculator
{
    public class McIntosh : IApple
    {
        private int NumberOfCups { get; set; }

        public McIntosh (int numberOfCups)
        {
            NumberOfCups = numberOfCups;
        }
        
        public double GetNumberOfApples()
        {
            return (1.25 * NumberOfCups);

        }
    }
}
