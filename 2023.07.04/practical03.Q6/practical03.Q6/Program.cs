using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical03.Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());

            ArrayManager arrayManager = new ArrayManager();
            int[] array = arrayManager.CreateArray(size);

            Console.WriteLine("Enter values for the array:");

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter value: ");
                int value = int.Parse(Console.ReadLine());

                arrayManager.SetValue(array, i, value);
            }

            Console.WriteLine("Array values with zeros:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.ReadLine();
        }
        }
    }

