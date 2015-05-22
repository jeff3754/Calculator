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
                    Calculation calculation = new Calculation();
                    Selection selection = new Selection();
                    ICalculator icalculator;
                    Console.WriteLine("----Welcome to the Magic calculator----");
                    icalculator = selection.SelectCalculatorMethod();
                    int operation = selection.SelectOperationMethod();
                    Console.Write("Enter the First number :");
                    double firstnumber = double.Parse(Console.ReadLine());
                    Console.Write("Enter the Second number :");
                    double secondnumber = double.Parse(Console.ReadLine());
                    double result = calculation.CalculationMethod(icalculator, operation, firstnumber, secondnumber);
                    icalculator.SaveResult(result);
                    Queue<double> m= icalculator.ViewResult();
                    Console.WriteLine("The Result is {0}", result);
                    Console.WriteLine("press y to view previous results");
                    switch(Console.ReadLine())
                    {
                        case "y": foreach (double j in m)
                                Console.WriteLine(j);
                            break;
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
