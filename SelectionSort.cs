using System;

namespace algo.selectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = selectionSort(new int[] { 5, 9, 2, 7, 1 });
            for(int i=0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.ReadKey();
        }

        public static int[] selectionSort(int[] a)
        {
            int min;
            for(int i = 0; i<a.Length; i++)
            {
                min = i;
                for(int j=i+1; j < a.Length; j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }
                }
                int temp = a[i];
                a[i] = a[min];
                a[min] = temp;
            }
            return a;
        }
    }
}
