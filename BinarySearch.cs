namespace algo.binarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        // p, q, r index variables
        // 1. p=0, r=a.length-1
        // 2. while p<=r do
        //     a) set q = p+r/2
        //     b) if A[q] == x return index positio
        //     c) if A[q] > X  set r = q-1else set p to q+1
        // 3. return -1

        public static int binarySearch(int[] a, int x)
        {
            int p = 0;
            int r = a.Length - 1;
            int q = 0;
            while (p <= r)
            {
                q = (p + r) / 2;
                if(a[q] == x)
                {
                    return q;
                }
                if(a[q] > x)
                {
                    r = q - 1;
                }
                else
                {
                    p = q + 1;
                }
            }
            return -1;
        }

        //recursive way
        public static int recursiveBinarySearch(int[] a, int p, int r, int x)
        {
            if (p > r)
            {
                return -1;
            }
            else
            {
                int q = (p + r) / 2;
                if(a[q] == x)
                {
                    return q;
                }else if(a[q] > x)
                {
                    return recursiveBinarySearch(a, p, q - 1, x);
                }
                else
                {
                    return recursiveBinarySearch(a, q+1, r, x);
                }
            }
        }
    }
}
