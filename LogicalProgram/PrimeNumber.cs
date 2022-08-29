using System;

namespace LogicalProgram
{
    internal class PrimeNumber
    {
        public static void CheckPrimeNumber()
        {
            int num, flag = 0, i;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 0 || num == 1)
            {
                flag = 1;
            }

            for (i = 2; i <= num / 2; i++)
            {
                if(num % i == 0)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine(num+" is a prime number");
            }
            else
            {
                Console.WriteLine(num+" is not a prime number");
            }
        }
    }
}
