using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class TemperaturConversion
    {
        public static void Temperature()
        {
            Console.WriteLine("Enter Celsius temperature");
            double c=Convert.ToDouble(Console.ReadLine());

            double f = (c * 9 / 5) + 32;
            Console.WriteLine("Calsius to Fahrenheit : "+f);

            c = (f - 32) * 5 / 9;
            Console.WriteLine("Fahrenheit to Celsius : "+c);
        }
    }
}
