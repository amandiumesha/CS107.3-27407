using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical01.Q3
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
                Console.WriteLine("The summation of the two numbers is: " + sum);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
            }

            Console.ReadLine(); 
        }

    }
}

