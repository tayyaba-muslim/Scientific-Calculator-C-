using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator App!\n");
            while (true)
            {
                Console.WriteLine("Select Calculator Type:\n");
                Console.WriteLine("1. Normal Calculator");
                Console.WriteLine("2. Scientific Calculator");
                Console.WriteLine("3. Exit\n");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("\nInvalid input. Please enter a valid choice.\n");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        RunNormalCalculator();
                        break;
                    case 2:
                        RunScientificCalculator();
                        break;
                    case 3:
                        Console.WriteLine("\nExiting Calculator App. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("\nInvalid choice. Please enter a valid option.\n");
                        break;
                }
            }
        }

        static void RunNormalCalculator()
        {
            Console.WriteLine("\nNormal Calculator Selected\n");
            Console.WriteLine("Enter first number:");
            double num1 = GetNumberFromUser();
            Console.WriteLine("\nEnter second number:");
            double num2 = GetNumberFromUser();

            Console.WriteLine("\nSelect Operation:\n");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            int operationChoice = int.Parse(Console.ReadLine());

            double result = 0;
            switch (operationChoice)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("\nError: Division by zero!");
                        return;
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("\nInvalid operation choice.");
                    return;
            }

            Console.WriteLine("Result: \n" + result);
        }

        static void RunScientificCalculator()
        {
            Console.WriteLine("Scientific Calculator Selected\n");
            Console.WriteLine("Enter a number:");
            double num = GetNumberFromUser();

            Console.WriteLine("\nSelect Operation:\n");
            Console.WriteLine("1. Exponentiation");
            Console.WriteLine("2. Square Root");
            Console.WriteLine("3. Logarithm (base 10)");
            Console.WriteLine("4. Sine");
            Console.WriteLine("5. Cosine");
            Console.WriteLine("6. Tangent");

            int operationChoice = int.Parse(Console.ReadLine());

            double result = 0;
            switch (operationChoice)
            {
                case 1:
                    Console.WriteLine("\nEnter the exponent:");
                    double exponent = GetNumberFromUser();
                    result = Math.Pow(num, exponent);
                    break;
                case 2:
                    if (num < 0)
                    {
                        Console.WriteLine("\nError: Square root of a negative number!");
                        return;
                    }
                    result = Math.Sqrt(num);
                    break;
                case 3:
                    if (num <= 0)
                    {
                        Console.WriteLine("\nError: Logarithm of a non-positive number!");
                        return;
                    }
                    result = Math.Log10(num);
                    break;
                case 4:
                    result = Math.Sin(num);
                    break;
                case 5:
                    result = Math.Cos(num);
                    break;
                case 6:
                    result = Math.Tan(num);
                    break;
                default:
                    Console.WriteLine("\nInvalid operation choice.");
                    return;
            }

            Console.WriteLine("Result: \n" + result);
        }

        static double GetNumberFromUser()
        {
            double num;
            while (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("\nInvalid input. Please enter a valid number:");
            }
            return num;
        }
    }
}