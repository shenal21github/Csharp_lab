using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the arrays:");
        int size = int.Parse(Console.ReadLine());

        int[] array1 = new int[size];
        int[] array2 = new int[size];

        Console.WriteLine("Enter values for the first array:");
        PopulateArray(array1);

        Console.WriteLine("Enter values for the second array:");
        PopulateArray(array2);

        Console.WriteLine("\nFirst Array:");
        DisplayArray(array1);

        Console.WriteLine("\nSecond Array:");
        DisplayArray(array2);

        int[] vectorSum = VectorSum(array1, array2);
        int[] vectorProduct = VectorProduct(array1, array2);

        Console.WriteLine("\nVector Sum:");
        DisplayArray(vectorSum);

        Console.WriteLine("\nVector Product:");
        DisplayArray(vectorProduct);

        int scalarSum = ScalarSum(array1) + ScalarSum(array2);
        int scalarProduct = ScalarProduct(array1, array2);

        Console.WriteLine("\nScalar Sum: " + scalarSum);
        Console.WriteLine("Scalar Product: " + scalarProduct);

        Console.ReadLine();
    }

    static void PopulateArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Enter value {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
    }

    static void DisplayArray(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write($"{element} ");
        }
    }

    static int[] VectorSum(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            result[i] = arr1[i] + arr2[i];
        }
        return result;
    }

    static int[] VectorProduct(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            result[i] = arr1[i] * arr2[i];
        }
        return result;
    }

    static int ScalarSum(int[] arr)
    {
        int sum = 0;
        foreach (int element in arr)
        {
            sum += element;
        }
        return sum;
    }

    static int ScalarProduct(int[] arr1, int[] arr2)
    {
        int product = 0;
        for (int i = 0; i < arr1.Length; i++)
        {
            product += arr1[i] * arr2[i];
        }
        return product;
    }
}
