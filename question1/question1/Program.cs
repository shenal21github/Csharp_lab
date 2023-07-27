using System;

namespace KilometerToMeterConverter
{
    class ConvertValues
    {
        public void KilometerToMeter()
        {
            Console.Write("Enter the value in kilometers (km): ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double kilometers))
            {
                double meters = kilometers * 1000;
                Console.WriteLine($"The value in meters (m) is: {meters} m");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number for kilometers.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Kilometer to Meter Converter!");

            // Create an object of the ConvertValues class
            ConvertValues converter = new ConvertValues();

            // Call the KilometerToMeter method to perform the conversion
            converter.KilometerToMeter();

            // Keep the console window open until the user presses a key
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}

