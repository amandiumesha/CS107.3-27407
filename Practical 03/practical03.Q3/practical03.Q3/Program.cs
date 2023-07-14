using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical03.Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int temp = number;

            for (; temp != 0; temp /= 10)
            {
                int digit = temp % 10;
                sum += digit;
            }

            Console.WriteLine("Sum of the digits: " + sum);
            Console.ReadKey();
        }
    }
}
