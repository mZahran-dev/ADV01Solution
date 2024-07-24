using System.Security.Cryptography;
using System;

namespace ADV01Assignment
{
    internal class Program
    {
        static void OptimizedBubbleSort(int[] array)
        {
            int n = array.Length;
            bool swapeed = false;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapeed = true;
                    }
                }
                if (!swapeed)
                    break;
            }


        }
        static void Main(string[] args)
        {

            #region 1.The Bubble Sort algorithm has a time complexity of O(n ^ 2) in its worst and average cases, which makes it inefficient for large datasets. How we can optimize the Bubble Sort algorithm
            //And implement the code of this optimized bubble sort algorithm

                // answer: we can optimize bubble sort by recognizing that once no elements are swapped during an iteration, the list is already sorted.
            int[] array = { 90, 3, 1, 56, 45, 3, 5, 6, 8 };

            OptimizedBubbleSort(array);
            Console.WriteLine("Sorted Array: ");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            #endregion
            
            #region 2.create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. The range should support basic operations such as checking if a value is within the range and determining the length of the range.

            Range<int> intRange = new Range<int>(5, 10);

            Console.WriteLine("Is 7 in range: " + intRange.IsInRange(7));
            Console.WriteLine("Is 11 in range: " + intRange.IsInRange(11));
            Console.WriteLine("Length of range: " + intRange.Length());

            Range<double> doubleRange = new Range<double>(2.0, 3.0);

            Console.WriteLine("Is 2.0 in range: " + doubleRange.IsInRange(2.0));
            Console.WriteLine("Is 3.0 in range: " + doubleRange.IsInRange(3.0));
            Console.WriteLine("Length of range: " + doubleRange.Length());

            Range<decimal> decimalRange = new Range<decimal>(1.5m, 2.5m);

            Console.WriteLine("Is 2.0 in range: " + decimalRange.IsInRange(2.0m));
            Console.WriteLine("Is 3.0 in range: " + decimalRange.IsInRange(3.0m));
            Console.WriteLine("Length of range: " + decimalRange.Length());

            #endregion


        }
    }
}
