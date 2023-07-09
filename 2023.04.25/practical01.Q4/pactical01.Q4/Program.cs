using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pactical01.Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the employee's salary: ");
            string salaryInput = Console.ReadLine();

            Console.Write("Enter the tax rate (in decimal form): ");
            string taxRateInput = Console.ReadLine();

            if (double.TryParse(salaryInput, out double salary) && double.TryParse(taxRateInput, out double taxRate))
            {
                double taxAmount = salary * taxRate;
                double netSalary = salary - taxAmount;

                Console.WriteLine("The salary after tax deduction is: " + netSalary);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid salary and tax rate.");
            }

            Console.ReadLine(); 
        }

    }
}

