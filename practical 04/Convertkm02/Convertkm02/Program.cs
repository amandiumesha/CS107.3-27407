using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertkm02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the distance in kilometers : ");
            double kilometers = Convert.ToDouble(Console.ReadLine());

            ConvertValues converter = new ConvertValues();
            converter.KilometerToMeter(kilometers);

            Console.ReadKey();
        }
    }
}
