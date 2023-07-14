using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical02.Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();

            if (int.TryParse(input1, out int number1) && int.TryParse(input2, out int number2))
            {
                int sum = number1 + number2;
                Console.WriteLine("The sum of the two numbers is: " + sum);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
            }

            Console.ReadLine();

        }
    }
}
