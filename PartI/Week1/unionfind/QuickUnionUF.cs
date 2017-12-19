using System;

namespace unionfind
{
    public class QuickUnionUF
    {
        int[] id;
        public int count { get; private set; }
        public QuickUnionUF(int N){
            count = N;
            id = new int[N];
            for(int i = 0; i < N;i++)
            {
                id[i] = i;
            }
        }

        public int find(int p)
        {
            while(p != id[p])
            {
                p = id[p];
            }
            return p;
        }

        public bool connected(int p, int q)
        {
            return find(p) == find(q);
        }

        public void union(int p, int q)
        {
            int rootP = find(p);
            int rootQ = find(q);
            if(rootP == rootQ) return;
            id[rootP] = rootQ;
            count--;
        }

        public void printList()
        {
            string s = "";
            foreach (var item in id)
            {
                s = s + item + " ";
            }
            Console.WriteLine(s);
        }
    }
}