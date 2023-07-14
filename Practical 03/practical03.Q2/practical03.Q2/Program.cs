using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical03.Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Word or a letter: ");
            string input = Console.ReadLine();

            int vowelCount = CountVowels(input);
            Console.WriteLine("Number of vowels: " + vowelCount);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static int CountVowels(string input)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";

            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(input[i]))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
    


