using System;

namespace elementarysorts
{
    public class Shell
    {
        public static void sort(IComparable[] a)
        {
            int N = a.Length;

            int h = 1;

            while(h < N/3)
            {
                h = 3 * h + 1;
            }

            while(h >= 1)
            {
                for(int i = h;i < N;i++)
                {
                    for(int j = i;j >= h && less(a[j],a[j-h]);j-=h)
                    {
                        exch(a,j,j-h);
                    }
                }
                h = h/3;
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