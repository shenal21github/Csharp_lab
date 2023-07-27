using System;

namespace DigitSumCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Digit Sum Calculator!");

            // Read the number from the user
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            // Parse the input to get the number as an integer
            if (int.TryParse(input, out int number))
            {
                // Calculate the sum of the digits using a for loop
                int sumOfDigits = 0;
                int tempNumber = Math.Abs(number); // Take the absolute value to handle negative numbers

                while (tempNumber > 0)
                {
                    int digit = tempNumber % 10;
                    sumOfDigits += digit;
                    tempNumber /= 10;
                }

                // Print the result
                Console.WriteLine($"The sum of the digits of {number} is: {sumOfDigits}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer number.");
            }

            // Keep the console window open until the user presses a key
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}

