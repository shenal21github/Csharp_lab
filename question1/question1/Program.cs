using System;

namespace EvenOddChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Even-Odd Checker!");

            // Read the number from the user
            Console.Write("Enter an integer number: ");
            string input = Console.ReadLine();

            // Parse the input to get the number as an integer
            if (int.TryParse(input, out int number))
            {
                // Check if the number is even or odd
                if (number % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
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

