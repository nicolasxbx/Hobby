using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hobby;

public class SortingAlgorithms
{
    public int[] CreateRandomArray(int arrayLength = 16)
    {
        int[] array = new int[arrayLength];
        Random rng = new(732874827);

        // Init Array
        for(int i = 0; i < arrayLength; i++)
        {
            array[i] = i;
        }

        // Shuffle Array
        for (int i = arrayLength - 1; i > 0; i--)
        {
            int j = rng.Next(i + 1);
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        return array;
    }

    public void PrintArray(int[] array)
    {
        foreach (int i in array)
        {
            if (i != 0) Console.Write(", ");
            Console.Write($"{i}");
        }
    }
}
