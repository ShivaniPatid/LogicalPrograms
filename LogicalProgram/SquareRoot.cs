using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class SquareRoot
    {
        public static void CalculateSquareRoot()
        {
            Console.WriteLine("Enter the number");
            int c=Convert.ToInt32(Console.ReadLine());


            int t = c;
            float epsilon = 0.00001f;  // where epsilon = 1e - 15
            if (Math.Abs(t - c / t) > epsilon * t)
            {
                Console.WriteLine(Math.Sqrt(c));
               
            }
        }
    }
}
