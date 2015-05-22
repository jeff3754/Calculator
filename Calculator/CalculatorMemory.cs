using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Calculator
{
    class CalculatorMemory:ICalculatorMemory
    {
        static Queue<double> memory = new Queue<double>();
        public void SaveResult(double result)
        {
               memory.Enqueue(result);
        }
        public Queue<double> ViewResult()
        {
            return memory;            
        }
    }
}
