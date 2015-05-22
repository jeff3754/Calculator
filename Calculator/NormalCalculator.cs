using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class NormalCalculator : ICalculator
    {
        private ICalculatorMemory Memory;

        public NormalCalculator(ICalculatorMemory memory)
        {
            this.Memory = memory;
        }

        public double Add(double firstnumber, double secondnumber)
        {
            return firstnumber + secondnumber;
        }

        public double Subtract(double firstnumber, double secondnumber)
        {
            return firstnumber - secondnumber;
        }

        public double Multiply(double firstnumber, double secondnumber)
        {
            return firstnumber * secondnumber;
        }

        public double Divide(double firstnumber, double secondnumber)
        {
            return firstnumber / secondnumber;
        }

        #region ICalculatorMemory Members

        public void SaveResult(double result)
        {
            Memory.SaveResult(result);
        }

        public Queue<double> ViewResult()
        {
            return Memory.ViewResult();
        }

        #endregion
    }
}
