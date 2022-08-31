using System;

namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome user...");
            Console.WriteLine("Choose Number\n 1. Fibonacci Series\t 2. Perfect Number\t 3. Prime Number\t 4. Reverse Number\t 5. Day of Week\n 6. Temperatur Conversion\t 7. Monthly payment\t 8. Square Root\t 9. Binary Conversion\t 10.Swap nibbles");
            int num=Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    FibonacciSeries.PrintFibonacciSeries();
                    break;
                case 2:
                    PerfectNumber.CheckPerfectNumber();
                    break;
                case 3:
                    PrimeNumber.CheckPrimeNumber();
                    break;
                case 4:
                    ReverseNumber.PrintReverseNumber();
                    break;
                case 5:
                    DayOfWeek.DayOrMonth();
                    break;
                case 6:
                    TemperaturConversion.Temperature();
                    break;
                case 7:
                    MonthlyPayment.CalculateMonthlyPayment();
                    break;
                case 8:
                    SquareRoot.CalculateSquareRoot();
                    break;
                case 9:
                    BinaryConversion.ToBinary();
                    break;
                case 10:
                    Console.WriteLine("New number is "+SwapNibbles.SwappingNibbles(100));
                    break;

                default:
                    Console.WriteLine("Choose Rigth Number");
                    break;
            }
        }
    }
}