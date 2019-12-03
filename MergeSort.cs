using System;

namespace algo.mergesort
{
    public class MergeSort
    {
        public void sort(int[] inputArray)
        {
            throw new NotImplementedException();
        }

        public void sort(int[] inputArray, int start, int end)
        {
            if (end <= start)
            {
                return;
            }
            int mid = (start + end) / 2;
            sort(inputArray, start, mid); // sort left half
            sort(inputArray, mid + 1, end);// sort right half
            merge(inputArray, start, mid, end);// merge sorted results into the inputArray

        }

        public void merge(int[] inputArray, int start, int mid, int end)
        {
            int[] tempArray = new int[end - start + 1];
            //index counter for the left side of the array
            int leftSlot = start;
            //index counter for the right side of the array
            int rightSlot = mid + 1;
            int k = 0;
            while(leftSlot <=mid && rightSlot <= end)
            {
                if (inputArray[leftSlot] < inputArray[rightSlot])
                {
                    tempArray[k] = inputArray[leftSlot];
                    leftSlot = leftSlot + 1;
                }
                else
                {
                    tempArray[k] = inputArray[rightSlot];
                    rightSlot = rightSlot + 1;
                }
                k = k + 1;
            }
            if(leftSlot <= mid)
            {
                while (leftSlot <= mid)
                {
                    tempArray[k] = inputArray[leftSlot];
                    leftSlot = leftSlot + 1;
                    k = k + 1;
                }
            }
            else if (rightSlot <= end)
            {
                while (rightSlot <= end)
                {
                    tempArray[k] = inputArray[rightSlot];
                    rightSlot = rightSlot + 1;
                    k = k + 1;
                }
            }

            // copy over the temp array into the appropriate slots of the inputarray
            for(int i=0; i < tempArray.Length; i++)
            {
                inputArray[start + i] = tempArray[i];
            }

        }
    }
}
