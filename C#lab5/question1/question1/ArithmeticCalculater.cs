using ArithmeticCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
    internal class ArithmeticCalculater
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Arithmetic Calculator!");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            // Read the user's choice
            Console.Write("Enter your choice (1/2/3/4): ");
            string choiceInput = Console.ReadLine();

            if (int.TryParse(choiceInput, out int choice))
            {
                // Read the two numbers from the user
                Console.Write("Enter the first number: ");
                string num1Input = Console.ReadLine();

                Console.Write("Enter the second number: ");
                string num2Input = Console.ReadLine();

                if (double.TryParse(num1Input, out double num1) && double.TryParse(num2Input, out double num2))
                {
                    // Create an object of the CalculateValues class
                    CalculateValues calculator = new CalculateValues();

                    double result = 0;

                    // Perform the chosen arithmetic operation based on the user's choice
                    switch (choice)
                    {
                        case 1:
                            result = calculator.Add(num1, num2);
                            break;
                        case 2:
                            result = calculator.Subtract(num1, num2);
                            break;
                        case 3:
                            result = calculator.Multiply(num1, num2);
                            break;
                        case 4:
                            result = calculator.Divide(num1, num2);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option (1/2/3/4).");
                            break;
                    }

                    // Display the final result
                    Console.WriteLine($"The result of the operation is: {result}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter valid numbers.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a valid option (1/2/3/4).");
            }

            // Keep the console window open until the user presses a key
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
        }
