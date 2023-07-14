using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical02.Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int NumberOfInputs = 10;

            Console.WriteLine("Enter 10 numbers:");

            for (int i = 1; i <= NumberOfInputs; i++)
            {
                Console.Write("Number " + i + ": ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    if (IsEven(number))
                    {
                        Console.WriteLine("Even");
                    }
                    else
                    {
                        Console.WriteLine("Odd");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            Console.ReadLine(); 
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }

}
    
