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
    public int[] array { get; set; } = default!;

    public SortingAlgorithms(int arrayLength = 16)
    {
        array = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            array[i] = i;
        }
    }    
    public void RandomizeArray()
    {
        Random rng = new(732874827);

        // Shuffle Array
        for (int i = array.Length - 1; i > 0; i--)
        {
            int j = rng.Next(i + 1);
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }

    public void PrintArray()
    {
        foreach (int i in array)
        {
            if (i != 0) Console.Write(", ");
            Console.Write($"{i}");
        }

        Console.Write("\n");
    }

    void Swap(int index1, int index2)
    {
        int temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }

    /// <summary>
    /// Go through the unsorted array and place the smallest value at the beginning. O=n^2
    /// </summary>
    public void LinearSort()
    {
        // Iterate through array
        for (int i = 0; i < array.Length; i++)
        {
            // the index of the lowest number of this cycle
            int minIndex = i;

            // Go through the unsorted array
            for (int j = i + 1; j < array.Length; j++)
            {
                // if a new minimum value is found, put the index of it in the minIndex variable.
                if (array[j] < array[minIndex]) minIndex = j;
            }

            Swap(minIndex, i);
        }
    }

    /// <summary>
    /// Iterate through the array and swap if the neighbour is 2. O=n^2
    /// </summary>
    public void BubbleSort()
    {
        // Iterate through the array
        for (int i = 0; i < array.Length; i++) //i is the starting point of the unsorted part
        {
            // Go through the unsorted part of the array
            for (int j = 0; j < array.Length -i-1; j++)
            {
                // if right-neighbour num is smaller, swap both nums.
                if (array[j] > array[j + 1]) Swap(j, j + 1);
            }
        }
    }
    public void BubbleSortReverse()
    {
        // Iterate through the array backwards
        for (int i = array.Length - 1; i >= 0; i--) //i is the starting point of the unsorted part
        {
            // Go through the unsorted part of the array
            for (int j = 0; j < i; j++)
            {
                // if right-neighbour num is smaller, swap both nums.
                if (array[j] > array[j + 1]) Swap(j, j + 1);
            }
        }
    }

    /// <summary>
    /// O=n^2
    /// </summary>
    public void InsertionSort()
    {
        // Iterate through the array, starting at the 2nd element
        for (int i = 1; i < array.Length; i++)
        {
            // the current element value
            int current = array[i];

            // the prev value
            int prev = i - 1;

            // 
            while (prev >= 0 && current < array[prev])
            {
                // 
                array[prev+1] = array[prev];
                prev--;
            }    
            
            //
            array[prev + 1] = current;
        }
    }

    public void SelectionSort()
    {
        
    }       

    public void MergeSort()
    {

    }

    public void QuickSort()
    {
        
    }

    public void HeapSort()
    {

    }
}
