using System;

namespace VowelCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Vowel Counter!");

            // Read the input string from the user
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Convert the input string to lowercase to handle both uppercase and lowercase vowels
            string lowerCaseInput = input.ToLower();

            // Initialize a counter to keep track of the number of vowels
            int vowelCount = 0;

            // Loop through each character in the string
            foreach (char c in lowerCaseInput)
            {
                // Check if the character is a vowel
                if (IsVowel(c))
                {
                    vowelCount++;
                }
            }

            // Print the result
            Console.WriteLine($"The number of vowels in the string is: {vowelCount}");

            // Keep the console window open until the user presses a key
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }

        // Helper method to check if a character is a vowel
        static bool IsVowel(char c)
        {
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }
    }
}

