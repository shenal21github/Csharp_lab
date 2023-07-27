using System;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Salary Calculator!");

            // Read the salary from the user
            Console.Write("Enter the salary of the employee: ");
            string salaryInput = Console.ReadLine();

            // Read the tax rate from the user
            Console.Write("Enter the tax rate (in decimal format, e.g., 0.2 for 20%): ");
            string taxRateInput = Console.ReadLine();

            // Parse the inputs to get the salary and tax rate as doubles
            if (double.TryParse(salaryInput, out double salary) && double.TryParse(taxRateInput, out double taxRate))
            {
                // Calculate the salary after tax deduction
                double salaryAfterTax = salary * (1 - taxRate);

                // Print the result
                Console.WriteLine($"Salary after tax deduction: {salaryAfterTax:F2}");
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
