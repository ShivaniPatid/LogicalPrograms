using System;

namespace LogicalProgram
{
    internal class ReverseNumber
    {
        public static void PrintReverseNumber()
        {
            int num, reminder, reverse = 0;
            Console.WriteLine("Enter the Number");
            num=Convert.ToInt32(Console.ReadLine());

            while (num > 0)
            {
                reminder = num % 10;
                reverse = reverse * 10 + reminder;
                num /= 10;
            }
            Console.WriteLine("Reverse number : "+reverse);
        }
        

    }
}
