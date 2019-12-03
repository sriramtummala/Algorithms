using System;
namespace algo.insertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int[] insertionSort(int[] a)
        {
            for(int i=1; i<a.Length; i++)
            {
                int element = a[i]; // element contains the data we intend on bringing over to the sorted side
                int j = i - 1; // j points to index position of last value in sorted area
                while(j>=0 && a[j] > element)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = element;
            }
            return a;
        }
    }
}
