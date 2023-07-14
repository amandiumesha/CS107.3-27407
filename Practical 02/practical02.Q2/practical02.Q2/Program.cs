using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical02.Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();

            if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
            {
                double sum = number1 + number2;
                double subtraction = number1 - number2;
                double multiplication = number1 * number2;

                if (number2 != 0)
                {
                    double division = number1 / number2;
                    Console.WriteLine("Sum: " + sum);
                    Console.WriteLine("Subtraction: " + subtraction);
                    Console.WriteLine("Multiplication: " + multiplication);
                    Console.WriteLine("Division: " + division);
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
            }

            Console.ReadLine(); 
        }

    }
}

