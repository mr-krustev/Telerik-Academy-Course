using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Calculate
{
    public static T Min<T>(params T[] array)
    {
        
        return array.Min();
    }

    public static T Max<T>(params T[] array)
    {
        return array.Max();
    }

    public static T AverageOf<T>(params T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum / (double)array.Length;
    }

    public static T SumOf<T>(params T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }

    public static T ProductOf<T>(params T[] array)
    {
        dynamic product = 1;
        foreach (var number in array)
        {
            product *= number;
        }

        return product;
    }
}

