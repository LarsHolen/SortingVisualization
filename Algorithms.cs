using System;
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
            Debug.WriteLine("SelectionSort Iterations: " + iterations);
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
                    (intArray[j + 1], intArray[j]) = (intArray[j], intArray[j + 1]);
                    j--;
                }
            }
        }

        /// <summary>
        /// QuickSort
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>

        public static void QuickSort(int[] data, int l, int r, int sleep, CancellationToken ct)
        {
            int i, j;
            int x;

            i = l;
            j = r;

            x = data[(l + r) / 2]; /* find pivot item */
            while (true)
            {
                Thread.Sleep(sleep);
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
        }

       

        public static void exchange(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
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