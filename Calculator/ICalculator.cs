using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface ICalculator:ICalculatorMemory
    {
        double Add(double firstnumber, double secondnumber);
        double Subtract(double firstnumber, double secondnumber);
        double Multiply(double firstnumber, double secondnumber);
        double Divide(double firstnumber, double secondnumber);
    }
}
