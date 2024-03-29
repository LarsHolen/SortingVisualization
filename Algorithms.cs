﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace SortingVisualization
{
    internal static class Algorithms
    {
        public static event EventHandler SortFinished = delegate {};

        /// <summary>
        /// Bubblesort
        /// </summary>
        /// <param name="intArray"></param>
        /// <param name="sleep"></param>
        /// <param name="ct"></param>
        internal static void BubbleSort(int[] intArray, int sleep, CancellationToken ct)
        {
            // Bouble sorting 
            int n = intArray.Length;
            bool swapped = true;
            int iterations = 0;
            while(swapped)
            {
                // Slowing it down for the visualization
                Thread.Sleep(sleep);
                swapped = false;
                for (int i = 1; i < n; i++)
                {
                    // Test is the sort is canceled and we must stop it
                    if (CancelCheck(ct)) return;
                    iterations++;
                    if (intArray[i-1] > intArray[i])
                    {
                        // tuple swapping
                        (intArray[i - 1], intArray[i]) = (intArray[i], intArray[i - 1]);
                        swapped = true;
                    }
                }
                n--;  
            }
            // Sleeping a little, so we finish drawing it
            Thread.Sleep(500);
            SortFinished.Invoke(null, EventArgs.Empty);
        }

        /// <summary>
        /// SelectionSort
        /// </summary>
        /// <param name="intArray"></param>
        /// <param name="sleep"></param>
        /// <param name="ct"></param>
        internal static void SelectionSort(int[] intArray, int sleep, CancellationToken ct)
        {
            int iterations = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                Thread.Sleep(sleep);
                int smallestIndex = i;
                for (int j = i+1; j < intArray.Length; j++)
                {
                    if(CancelCheck(ct)) return;
                    iterations++;
                    if (intArray[j] < intArray[smallestIndex])
                    {
                        smallestIndex = j;
                    }
                }
                (intArray[smallestIndex], intArray[i]) = (intArray[i], intArray[smallestIndex]);
            }
            // Sleeping a little, so we finish drawing it
            Thread.Sleep(500);
            SortFinished.Invoke(null, EventArgs.Empty);
        }
        
        /// <summary>
        /// InsertionSort
        /// </summary>
        /// <param name="intArray"></param>
        /// <param name="sleep"></param>
        /// <param name="ct"></param>
        internal static void InsertionSort(int[] intArray, int sleep, CancellationToken ct)
        {
            int n = intArray.Length;
            int current;
            int j;
            for (int i = 1; i < n; i++)
            {
                Thread.Sleep(sleep);
                current = intArray[i];
                j = i - 1;
                while (j >= 0 && intArray[j] > current)
                {
                    if (CancelCheck(ct)) return;
                    intArray[j + 1] = intArray[j];
                    j--;
                }
                intArray[j + 1] = current;
            }
            // Sleeping a little, so we finish drawing it
            Thread.Sleep(500);
            SortFinished.Invoke(null, EventArgs.Empty);
        }

        /// <summary>
        /// QuickSort
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>

        internal static void QuickSort(int[] data, int l, int r, int sleep, CancellationToken ct)
        {
            int i, j;
            int x;

            i = l;
            j = r;

            x = data[(l + r) / 2]; /* find pivot item */
            while (true)
            {
                Thread.Sleep(sleep);
                if (CancelCheck(ct)) return;
                while (data[i] < x)
                    i++;
                while (x < data[j])
                    j--;
                if (i <= j)
                {
                    (data[i], data[j]) = (data[j], data[i]);
                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }
            if (l < j)
                QuickSort(data, l, j, sleep, ct);
            if (i < r)
                QuickSort(data, i, r, sleep, ct);
            if (l == 0 && r == data.Length - 1)
            {
                // Sleeping a little, so we finish drawing it
                Thread.Sleep(500);
                SortFinished.Invoke(null, EventArgs.Empty);
            }
        }


        internal static void MySort(int[] intArray, int sleep, CancellationToken ct)
        {
            Dictionary<int, int> sortDict = new();
            int max = intArray[0];
            int min = intArray[0];
            for (int i = 0; i < intArray.Length; i++)
            {
                if (CancelCheck(ct)) return;
                if (max < intArray[i]) max = intArray[i];
                if (min > intArray[i]) min = intArray[i];

                if(sortDict.ContainsKey(intArray[i]))
                {
                    sortDict[intArray[i]]++;
                } else
                {
                    sortDict.Add(intArray[i], 1);
                }
                
            }
            int index = 0;
            for (int i = min; i < max+1; i++)
            {
                if (CancelCheck(ct)) return;
                if (sortDict.ContainsKey(i))
                {
                    Thread.Sleep(sleep);
                    if (sortDict[i] > 1)
                    {
                        // Dict have value above 1, meaning there where multiple
                        // elements with this key. Loop it an fill the array.
                        for (int j = 0; j < sortDict[i]; j++)
                        {
                            
                            intArray[index] = i;
                            index++;
                        }
                    } else
                    {
                        // only one element with this key
                        intArray[index] = i;
                        index++;
                    }
                }
            }
            // Sleeping a little, so we finish drawing it
            Thread.Sleep(500);
            SortFinished.Invoke(null, EventArgs.Empty);
        }


        internal static void MySort2(int[] intArray, int sleep, CancellationToken ct)
        {
            int max = intArray[0];
            int min = intArray[0];
            for (int i = 0; i < intArray.Length; i++)
            {
                if (CancelCheck(ct)) return;
                if (max < intArray[i]) max = intArray[i];
                if (min > intArray[i]) min = intArray[i];
            }

            int[] countArray = new int[max - min + 1];
            for (int i = 0; i < intArray.Length; i++)
            {
                if (CancelCheck(ct)) return;
                countArray[intArray[i] - min]++;
            }

            int index = 0;
            for (int i = 0; i < countArray.Length; i++)
            {
                if (CancelCheck(ct)) return;
                Thread.Sleep(sleep);
                for (int j = 0; j < countArray[i]; j++)
                {
                    intArray[index] = i + min;
                    index++;
                }
            }

            // Sleeping a little, so we finish drawing it
            Thread.Sleep(500);
            SortFinished.Invoke(null, EventArgs.Empty);
        }




        /// <summary>
        /// Stop search!
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        private static bool CancelCheck(CancellationToken ct)
        {
            // Cancellation requested?
            if (ct.IsCancellationRequested)
            {
                Debug.WriteLine("Task was cancelled.");
                return true;
                //ct.ThrowIfCancellationRequested();
            }
            return false;
        }

        
    }
}