using System;

namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome user...");
            Console.WriteLine("Choose Number\n 1. Fibonacci Series\t 2. Perfect Number");
            int num=Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    FibonacciSeries.PrintFibonacciSeries();
                    break;
                case 2:
                    PerfectNumber.CheckPerfectNumber();
                    break;
                default:
                    Console.WriteLine("Choose Rigth Number");
                    break;
            }
        }
    }
}