using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    interface ICalculatorMemory
    {
        void SaveResult(double result);
        Queue<double> ViewResult();
    }
}
