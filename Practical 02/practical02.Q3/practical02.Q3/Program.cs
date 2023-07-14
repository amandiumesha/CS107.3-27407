using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical02.Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            string radiusInput = Console.ReadLine();

            if (double.TryParse(radiusInput, out double radius))
            {
                double area = CalculateCircleArea(radius);
                double circumference = CalculateCircleCircumference(radius);

                Console.WriteLine("Area of the circle: " + area);
                Console.WriteLine("Circumference of the circle: " + circumference);
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

        static double CalculateCircleCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }

    }
}

