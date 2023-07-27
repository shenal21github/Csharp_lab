using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
    internal class ArrayHandler
    {
    }
    {
    public int[] CreateArrayWithZeroes(int size)
    {
        int[] arr = new int[size * 2]; // Doubling the size to accommodate the 0s after each value
        return arr;
    }

    public void PopulateArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i += 2)
        {
            Console.Write($"Enter value {i / 2 + 1}: ");
            int value = int.Parse(Console.ReadLine());
            arr[i] = value;
            arr[i + 1] = 0; // Inserting a 0 after each user input value
        }
    }
}
}
