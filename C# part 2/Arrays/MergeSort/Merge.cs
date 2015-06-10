/*
Problem 13.* Merge sort

Write a program that sorts an array of integers using the Merge sort algorithm.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Merge
{

    static List<List<int>> listOfLists = new List<List<int>>();
    static void FillingArrayWithNumbers(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Number[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

    }

    static void FillListsOfLists(int[] array, List<List<int>> listOfLists)
    {
        if (array.Length % 2 == 0)
        {
            for (int i = 0; i < array.Length; i += 2)
            {
                for (int j = i + 1; j < i + 2; j++)
                {
                    listOfLists.Add(new List<int> { array[i], array[j] });
                }
            }
        }
        else
        {
            for (int i = 0; i < array.Length; i += 2)
            {
                for (int j = i + 1; j < i + 2 && j < array.Length; j++)
                {
                    listOfLists.Add(new List<int> { array[i], array[j] });
                }
            }
            listOfLists.Add(new List<int> { array[array.Length - 1] });
        }
    }

    static List<List<int>> ArrangeEachMerge(List<List<int>> listOfLists)
    {
        if (listOfLists.Count < 2)
        {
            return listOfLists;
        }

        for (int i = 0; i < listOfLists.Count; i++)
        {
            if (listOfLists.Count % 2 == 0)
            {
                for (int j = 0; j < listOfLists[i].Count - 1; j++)
                {
                    if (listOfLists[i][j] > listOfLists[i][j + 1])
                    {
                        int temp = listOfLists[i][j];
                        listOfLists[i][j] = listOfLists[i][j + 1];
                        listOfLists[i][j + 1] = temp;
                    }
                }
            }
            else if (listOfLists.Count % 2 != 0 && i + 1 < listOfLists.Count)
            {
                for (int j = 0; j < listOfLists[j].Count - 1; j++)
                {
                    if (listOfLists[i][j] > listOfLists[i][j + 1])
                    {
                        int temp = listOfLists[i][j];
                        listOfLists[i][j] = listOfLists[i][j + 1];
                        listOfLists[i][j + 1] = temp;
                    }
                }

            }
        }

        return MergeLists(ArrangeEachMerge(listOfLists));
    }

    static List<List<int>> MergeLists(List<List<int>> listOfLists)
    {
        for (int i = 0; i < listOfLists.Count - 1; i++)
        {
            for (int j = 0; j < listOfLists[i + 1].Count; j++)
            {
                listOfLists[i].Add(listOfLists[i + 1][j]);
            }

            listOfLists.RemoveAt(i + 1);
        }

        return listOfLists;
    }

    static void Print(List<List<int>> listOfLists, int[] array)
    {
        for (int i = 0; i < listOfLists.Count; i++)
        {

            for (int j = 0; j < listOfLists[i].Count; j++)
            {
                Console.Write(listOfLists[i][j] + " ");
            }
            Console.WriteLine();

        }
    }


    static void Main()
    {
        int arraySize = int.Parse(Console.ReadLine());
        int[] numbersInArray = new int[arraySize];

        FillingArrayWithNumbers(numbersInArray);

        FillListsOfLists(numbersInArray, listOfLists);

        ArrangeEachMerge(listOfLists);

        Print(listOfLists, numbersInArray);

    }
}

