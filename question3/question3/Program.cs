using System;

namespace CircleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Calculator!");

            // Read the radius from the user
            Console.Write("Enter the radius of the circle: ");
            string radiusInput = Console.ReadLine();

            // Parse the input to get the radius as a double
            if (double.TryParse(radiusInput, out double radius))
            {
                // Calculate the area of the circle
                double area = Math.PI * Math.Pow(radius, 2);

                // Calculate the circumference of the circle
                double circumference = 2 * Math.PI * radius;

                // Print the results
                Console.WriteLine($"Area of the circle: {area:F2}");
                Console.WriteLine($"Circumference of the circle: {circumference:F2}");
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

