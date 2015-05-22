using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    var calculation = new Calculation();
                    var selection = new Selection();
                    ICalculator icalculator;

                    Console.WriteLine("----Welcome to the Magic calculator----");
                    icalculator = selection.SelectCalculatorMethod();

                    var operation = selection.SelectOperationMethod();
                    Console.Write("Enter the First number :");

                    var firstnumber = double.Parse(Console.ReadLine());
                    Console.Write("Enter the Second number :");

                    var secondnumber = double.Parse(Console.ReadLine());
                    var result = calculation.CalculationMethod(icalculator, operation, firstnumber, secondnumber);
                    icalculator.SaveResult(result);

                    Queue<double> m= icalculator.ViewResult();

                    Console.WriteLine("The Result is {0}", result);
                    Console.WriteLine("press y to view previous results");

                    if (Console.ReadLine() == "y")
                    {
                        foreach (double j in m) Console.WriteLine(j);
                    }
                }
                catch
                {
                    Console.WriteLine("Numbers Only !");
                }
            }
        }
    }
}
