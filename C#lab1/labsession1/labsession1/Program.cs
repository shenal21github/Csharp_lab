using System;

namespace CircleAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Area Calculator!");

            // Read the radius from the user
            Console.Write("Please enter the radius of the circle: ");
            string input = Console.ReadLine();

            // Parse the input to get the radius as a double
            if (double.TryParse(input, out double radius))
            {
                // Calculate the area of the circle
                double area = Math.PI * Math.Pow(radius, 2);

                // Print the result
                Console.WriteLine($"The area of the circle with radius {radius} is: {area:F2}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number for the radius.");
            }

            // Keep the console window open until the user presses a key
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
