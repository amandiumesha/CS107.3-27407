using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical04.Q2
{
    internal class ArithmeticCalculator
    {
        private int num1;
        private int num2;

        public int Number1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public int Number2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public int Add()
        {
            return num1 + num2;
        }

        public int Subtract()
        {
            return num1 - num2;
        }

        public int Multiply()
        {
            return num1 * num2;
        }

        public double Divide()
        {
            if (num2 != 0)
            {
                return (double)num1 / num2;
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
                return 0;
            }
        }
    }
}

    

