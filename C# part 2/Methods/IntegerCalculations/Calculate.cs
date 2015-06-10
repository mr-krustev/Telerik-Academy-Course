using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Calculate
{
    public static int Min(int[] array)
    {
        int minimumNumber = int.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minimumNumber)
            {
                minimumNumber = array[i];
            }
        }
        return minimumNumber;
    }

    public static int Max(int[] array)
    {
        int maximumNumber = array.Max();
        return maximumNumber;
    }

    public static double AverageOf(int[] array)
    {
        List<int> list = array.ToList();
        return list.Average();
    }

    public static int SumOf(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }

    public static long ProductOf(int[] array)
    {
        long product = 1;
        foreach (var number in array)
        {
            product *= number;
        }

        return product;
    }
}

