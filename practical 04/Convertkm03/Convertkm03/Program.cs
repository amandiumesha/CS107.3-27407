using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertkm03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the distance in kilometers : ");
            double kilometers = Convert.ToDouble(Console.ReadLine());

            ConvertValues converter = new ConvertValues();
            double meters = converter.KilometerToMeter(kilometers);

            Console.WriteLine(kilometers + " kilometers is equal to " + meters + " meters.");
            Console.ReadKey();
        }
    }
}
