using System;

namespace algo.quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 9, 7, 3, 1, 6, 3, 2, 6, 8, 9, 2, 3, 0 };

            quicksort(inputArray, 0, inputArray.Length-1);

            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine(inputArray[i]);
            }
            Console.ReadKey();
        }

        public static void quicksort(int[] inputArray, int start, int end)
        {
            if (start < end)
            {
                int pp = partition(inputArray, start, end); //indexer position of correctly placed pivot value
                quicksort(inputArray, start, pp - 1); // sorts the left half of the range
                quicksort(inputArray, pp + 1, end); // sorts the right half of the range
            }
        }

        public static int partition(int[] inputArray, int start, int end)
        {
            int pivot = inputArray[end];
            int i = start - 1;
            for (int j =start; j <= end - 1; j++)
            {
                if (inputArray[j] <= pivot)
                {
                    i++;
                    int ival = inputArray[i];
                    int jval = inputArray[j];
                    inputArray[i] = jval;
                    inputArray[j] = ival;
                }
            }
            // put the pivot value in the current slot
            int inewval = inputArray[i + 1];
            inputArray[end] = inewval;
            inputArray[i + 1] = pivot; // pivot is placed in the right position

            return i+1;
        }
    }
}
