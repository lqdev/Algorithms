using System;

namespace unionfind
{
    public class QuickUnionUF
    {
        int[] parent;
        public int count { get; private set; }
        public QuickUnionUF(int N){
            count = N;
            parent = new int[N];
            for(int i = 0; i < N;i++)
            {
                parent[i] = i;
            }
        }

        public int find(int p)
        {
            while(p != parent[p])
            {
                p = parent[p];
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
            parent[rootP] = rootQ;
            count--;
        }

        public void printList()
        {
            string s = "";
            foreach (var item in parent)
            {
                s = s + item + " ";
            }
            Console.WriteLine(s);
        }
    }
}