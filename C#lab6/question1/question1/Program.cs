using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the array:");
        int size = int.Parse(Console.ReadLine());

        ArrayHandler arrayHandler = new ArrayHandler();
        int[] arr = arrayHandler.CreateArrayWithZeroes(size);

        Console.WriteLine("Enter values for the array (followed by 0 for each value):");
        arrayHandler.PopulateArray(arr);

        Console.WriteLine("\nFinal Array:");
        foreach (int element in arr)
        {
            Console.Write($"{element} ");
        }

        Console.ReadLine();
    }
}
