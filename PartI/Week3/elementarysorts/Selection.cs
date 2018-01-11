using System;

namespace elementarysorts
{
    public class Selection
    {
        public static void sort(IComparable[] a) {
            int N = a.Length;
            for(int i = 0; i < N; i++)
            {
                int min = i;
                for(int j = i + 1;j<N;j++)
                {
                    if(less(a[j],a[min]))
                    {
                        min = j;
                    }
                }
                exch(a,i,min);
            }
        }

        private static bool less(IComparable v, IComparable w)
        {
            return v.CompareTo(w) < 0;
        }

        private static void exch(object[] a, int i, int j)
        {
            object swap = a[i];
            a[i] = a[j];
            a[j] = swap;
        }
    }
}