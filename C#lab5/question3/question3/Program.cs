using System;

namespace ArrayOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Array Operations!");

            // Declare an array to store 10 elements
            int[] array = new int[10];

            // Read input values for the array
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter value for element {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    array[i] = value;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    i--; // To re-enter the value for the current index
                }
            }

            // Find minimum value
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            // Find maximum value
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            // Find average value
            int sum = 0;
            foreach (int value in array)
            {
                sum += value;
            }
            double average = (double)sum / array.Length;
            // Reverse order of values
            int[] reversedArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[i] = array[array.Length - i - 1];
            }

            // Print the results
            Console.WriteLine($"Minimum value: {min}");
            Console.WriteLine($"Maximum value: {max}");
            Console.WriteLine($"Average value: {average:F2}");
            Console.WriteLine("Reverse order of values:");
            foreach (int value in reversedArray)
            {
                Console.Write($"{value} ");
            }

            // Keep the console window open until the user presses a key
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
