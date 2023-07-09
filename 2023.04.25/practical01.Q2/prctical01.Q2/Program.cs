using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prctical01.Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            string radiusinput = Console.ReadLine();

            if (double.TryParse(radiusinput, out double radius))
            {
                double area = CalculateCircleArea(radius);
                Console.WriteLine("The area of the circle is: " + area);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid radius.");
            }

            Console.ReadLine();
        }

        static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

    }
}

