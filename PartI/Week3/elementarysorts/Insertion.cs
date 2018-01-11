using System;

namespace elementarysorts
{
    public class Insertion
    {
        public static void sort(IComparable[] a)
        {
            int N = a.Length;
            for(int i = 0; i < N;i++)
            {
                for(int j = i;j > 0;j--)
                {
                    if(less(a[j],a[j-1]))
                    {
                        exch(a,j,j-1);
                    } else 
                    {
                        break;
                    }
                }
            }
        }

        private static bool less(IComparable v, IComparable w)
        {
            return v.CompareTo(w) < 0;
        }

        private static void exch(object[] a,int i, int j)
        {
            object swap = a[i];
            a[i] = a[j];
            a[j] = swap;
        }
    }
}