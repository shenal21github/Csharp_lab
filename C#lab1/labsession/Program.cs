using System;

namespace NameAndBatchConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your batch:");
            string batch = Console.ReadLine();

            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Your batch is: " + batch);

            // Keep the console window open until the user presses a key
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
