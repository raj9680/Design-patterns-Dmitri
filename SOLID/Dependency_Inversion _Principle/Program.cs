using System;


/* 

Dependency Inversion Principle states

1). High-level modules should not depend on low-level modules. Both should depend on abstractions.

2). Abstractions should not depend on details. Details should depend on abstractions. 
 
*/
namespace Dependency_Inversion__Principle
{
    // Parent Interface or Abstract
    public interface ICalculatorOperation
    {
        double Calculate(double x, double y);
    }


    // High Level Class
    class Calculator
    {
        private ICalculatorOperation _calculator;
        public Calculator(ICalculatorOperation calculatorOperation)
        {
            _calculator = calculatorOperation;
        }
        public double Solve(double x, double y)
        {
            return _calculator.Calculate(x, y);
        }
    }


    // Low Level Classes
    public class AddCalculatorOperation : ICalculatorOperation
    {
        public double Calculate(double x, double y)
        {
            return x + y;
        }
    } // Separate class for Addition

    public class SubtractCalculatorOperation : ICalculatorOperation
    {
        public double Calculate(double x, double y)
        {
            return x - y;
        }
    }  // Separate class for Subscraction

    public class MultiplyCalculatorOperation : ICalculatorOperation
    {
        public double Calculate(double x, double y)
        {
            return x * y;
        }
    }  // Separate class for Multiplication




    // Mains
    class Program
    {
        static void Main(string[] args)
        {
            // Method
            static void AddSample(int x, int y)
            {
                Calculator calculator = new Calculator(new AddCalculatorOperation());
                double result = calculator.Solve(x, y);
                Console.WriteLine(result);
            }
            AddSample(22, 33);

        }
    }
}
