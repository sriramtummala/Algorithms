namespace algo.linearsearch
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int linearSearch(int[] a, int x)
        {
            for(int i = 0; i< a.Length; i++)
            {
                if(a[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
