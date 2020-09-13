using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0; int num2 = 0;

            Console.WriteLine("Simple Console Calculator in C#\r");
            Console.WriteLine("-------------------------------\n");

            Console.Write("Enter first number: ");
            num1 = NumbersCheck();

            Console.Write("Enter second number: ");
            num2 = NumbersCheck();
        }

        static int NumbersCheck()
        {
            Nullable<int> num = null;
            while (true)
            {
                if (num != null)
                {
                    break;
                }
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Incorrect numbers.");
                    Console.Write("Try again: ");
                    num = null;
                }
            }
            return (int)num;
        }
    }
}
