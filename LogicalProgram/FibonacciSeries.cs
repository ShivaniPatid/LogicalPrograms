using System;

namespace LogicalProgram
{
    internal class FibonacciSeries
    {
        public static void PrintFibonacciSeries()
        {
            int num1 = 0, num2 = 1, num3 = 0, number;
            Console.WriteLine("Enter a number");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write(num1+"\t"+num2);
            
            for(int i = 2; i < number; i++)
            {
                num3 = num1 + num2;
                Console.Write(num3+"\t");
                num1 = num2;
                num2 = num3;

            }
        }
    }
}
