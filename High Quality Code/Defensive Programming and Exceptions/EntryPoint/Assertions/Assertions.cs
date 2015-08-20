using System;
using System.Linq;
using System.Diagnostics;

public class AssertionTests
{
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Null reference.");
        Debug.Assert(arr.Length > 0, "Array cannot be empty.");

        var length = arr.Length - 1;
        for (int index = 0; index < arr.Length-1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }

        Debug.Assert(arr.Length == length, "Input and output arrays have different lengths.");
    }
  
    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array cannot be null.");
        Debug.Assert(arr.Length > 0, "Array cannot be empty.");

        Debug.Assert(startIndex != null, "startIndex cannot be null.");
        Debug.Assert(startIndex >= 0, "startIndex cannot be negative.");
        Debug.Assert(startIndex < arr.Length, "startIndex cannot be bigger than array size.");

        Debug.Assert(endIndex != null, "endIndex cannot be null.");
        Debug.Assert(endIndex >= 0, "endIndex cannot be negative.");
        Debug.Assert(endIndex < arr.Length, "endIndex cannot be bigger than array size.");
        Debug.Assert(endIndex > startIndex, "endIndex cannot be bigger than startIndex.");

        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }
        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array cannot be null.");
        Debug.Assert(arr.Length > 0, "Array cannot be empty.");

        Debug.Assert(startIndex != null, "startIndex cannot be null.");
        Debug.Assert(startIndex >= 0, "startIndex cannot be negative.");
        Debug.Assert(startIndex < arr.Length, "startIndex cannot be bigger than array size.");

        Debug.Assert(endIndex != null, "endIndex cannot be null.");
        Debug.Assert(endIndex >= 0, "endIndex cannot be negative.");
        Debug.Assert(endIndex < arr.Length, "endIndex cannot be bigger than array size.");
        Debug.Assert(endIndex > startIndex, "endIndex cannot be bigger than startIndex.");

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }
            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else 
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
    }

    
}
