using System;


namespace LogicalProgram
{
    internal class PerfectNumber
    {
        public static void CheckPerfectNumber()
        {
            int num, rem, sum = 0, i;
            Console.WriteLine("Enter the Number");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i < num; i++)
            {
                rem = num % i;
                if (rem == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine(num+" is a perfect number");
            }
            else
            {
                Console.WriteLine(num+" is not a prefect number");
            }
        }
    }
}
