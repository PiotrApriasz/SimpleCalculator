using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int num1 = 0; int num2 = 0;
                char again = 'x';

                Console.Clear();

                Console.WriteLine("Simple Console Calculator in C#\r");
                Console.WriteLine("-------------------------------\n");

                Console.Write("Enter first number: ");
                num1 = NumbersCheck();

                Console.Write("\nEnter second number: ");
                num2 = NumbersCheck();

                Console.Write("\nEnter symbol for math operation. Allowed: '+', '-', '*', '/', '%': ");

                switch (Console.ReadLine())
                {
                    case "+":
                        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                        break;
                    case "-":
                        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                        break;
                    case "*":
                        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                        break;
                    case "/":
                        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                        break;
                    case "%":
                        Console.WriteLine($"Your result: {num1} % {num2} = " + (num1 % num2));
                        break;
                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }

                while (true)
                {
                    Console.Write("\nDo you want to try again? [Y/n]: ");
                    again = Convert.ToChar(Console.ReadLine());

                    if (Char.ToUpper(again) == 'Y' || Char.ToLower(again) == 'n')
                    {
                        break;
                    }

                    Console.WriteLine("Incorrect data");
                }
                if (Char.ToLower(again) == 'n')
                {
                    Console.WriteLine("\nThank you! Goodbye");
                    break;
                }
            }
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
