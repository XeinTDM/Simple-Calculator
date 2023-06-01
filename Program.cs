using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("XeinTDM Calculator \n------------------");
            Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");

            if (!int.TryParse(Console.ReadLine(), out int input) || input < 1 || input > 4)
            {
                Console.WriteLine("Invalid Option");
                Console.ReadLine();
                return;
            }

            Console.Clear();

            double result;

            switch (input)
            {
                case 1:
                    result = PerformAddition();
                    break;
                case 2:
                    result = PerformSubtraction();
                    break;
                case 3:
                    result = PerformMultiplication();
                    break;
                case 4:
                    result = PerformDivision();
                    break;
                default:
                    Console.WriteLine("Invalid");
                    Console.ReadLine();
                    return;
            }

            Console.Clear();
            Console.WriteLine($"The result is: {result}");
            Console.ReadLine();
        }

        static double PerformAddition()
        {
            Console.WriteLine("You inputted Addition");
            System.Threading.Thread.Sleep(1200);
            Console.Clear();

            Console.WriteLine("First Number: ");
            double num1 = GetNumberFromUser();

            Console.WriteLine("Second Number: ");
            double num2 = GetNumberFromUser();

            return num1 + num2;
        }

        static double PerformSubtraction()
        {
            Console.WriteLine("You inputted Subtraction");
            System.Threading.Thread.Sleep(1200);
            Console.Clear();

            Console.WriteLine("First Number: ");
            double num1 = GetNumberFromUser();

            Console.WriteLine("Second Number: ");
            double num2 = GetNumberFromUser();

            return num1 - num2;
        }

        static double PerformMultiplication()
        {
            Console.WriteLine("You inputted Multiplication");
            System.Threading.Thread.Sleep(1200);
            Console.Clear();

            Console.WriteLine("First Number: ");
            double num1 = GetNumberFromUser();

            Console.WriteLine("Second Number: ");
            double num2 = GetNumberFromUser();

            return num1 * num2;
        }

        static double PerformDivision()
        {
            Console.WriteLine("You inputted Division");
            System.Threading.Thread.Sleep(1200);
            Console.Clear();

            Console.WriteLine("First Number: ");
            double num1 = GetNumberFromUser();

            Console.WriteLine("Second Number: ");
            double num2 = GetNumberFromUser();

            if (num2 == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                Console.ReadLine();
                return double.NaN;
            }

            return num1 / num2;
        }

        static double GetNumberFromUser()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid number: ");
            }
            return number;
        }
    }
}
