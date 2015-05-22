using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Selection
    {
        int operation;
        ICalculator icalculator;
        public ICalculator SelectCalculatorMethod()
        {
            Console.WriteLine("\nSelect a Calculator\n1. Normal Calculator.\n2. Magic Calculator.");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1: icalculator = new NormalCalculator(new CalculatorMemory());
                    break;
                case 2: icalculator = new MagicCalculator(new CalculatorMemory());
                    break;
                default: Console.WriteLine("\nEnter a valid choice");
                    this.SelectCalculatorMethod();
                    break;
            }
            return icalculator;
        }
        public int SelectOperationMethod()
        {
            Console.WriteLine("\nSelect an Operation\n1. Addition.\n2. Subtraction.\n3. Multiplication.\n4. Division.");
            operation = int.Parse(Console.ReadLine());
            switch (operation)
            {
                case 1:case 2:case 3:case 4: return operation;
                default: Console.WriteLine("\nSelect a valid Operation");
                    this.SelectOperationMethod();
                    return operation;
            }
        }
    }
}
