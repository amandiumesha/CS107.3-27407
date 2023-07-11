using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical04.Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithmeticCalculator calculator = new ArithmeticCalculator();

            
            calculator.Number1 = 50;
            calculator.Number2 = 2;

           
            int sum = calculator.Add();
            int difference = calculator.Subtract();
            int product = calculator.Multiply();
            double quotient = calculator.Divide();

            
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);

            Console.ReadLine();
        }
    }
}
    

