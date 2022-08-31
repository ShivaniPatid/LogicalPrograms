using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class BinaryConversion
    {
        public static void ToBinary()
        {
            string result;

            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            result = "";
            while (num > 1)
            {
                int reminder = num % 2;
                result = Convert.ToString(reminder) + result;
                num /= 2;
            }
            result=Convert.ToString(num)+result;
            Console.WriteLine("Binarey : "+result);

        }
    }
}
