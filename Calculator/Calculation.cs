using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculation
    {
        public double CalculationMethod(ICalculator icalculator, int operation, double firstnumber, double secondnumber)
        {
            switch (operation)
            {
                case 1: return icalculator.Add(firstnumber, secondnumber);
                case 2: return icalculator.Subtract(firstnumber, secondnumber);
                case 3: return icalculator.Multiply(firstnumber, secondnumber);
                case 4: return icalculator.Divide(firstnumber, secondnumber);
                default: return 0;
            }
        }
    }
}
