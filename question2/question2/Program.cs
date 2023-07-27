
using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Basic Calculator!");

            // Read the first input number
            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();

            // Read the second input number
            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();

            // Parse the inputs to get the numbers as doubles
            if (double.TryParse(input1, out double num1) && double.TryParse(input2, out double num2))
            {
                // Calculate the sum of the two numbers
                double sum = num1 + num2;
                Console.WriteLine($"Sum: {sum}");

                // Calculate the subtraction of the two numbers
                double subtraction = num1 - num2;
                Console.WriteLine($"Subtraction: {subtraction}");

                // Calculate the multiplication of the two numbers
                double multiplication = num1 * num2;
                Console.WriteLine($"Multiplication: {multiplication}");

                // Check if the second number is not zero for division
                if (num2 != 0)
                {
                    // Calculate the division of the two numbers
                    double division = num1 / num2;
                    Console.WriteLine($"Division: {division}");
                }
                else
                {
                    Console.WriteLine("Cannot perform division. The second number cannot be zero.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
            }

            // Keep the console window open until the user presses a key
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
