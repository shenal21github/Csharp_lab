using System;

namespace SumCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Sum Calculator!");

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

                // Print the result
                Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
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
