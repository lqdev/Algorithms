using System;

namespace unionfind
{
    public class WeightedQuickUnionUF
    {
        int[] parent;
        int[] size;
        public int count { get; private set; }
        public WeightedQuickUnionUF(int N){
            count = N;
            parent = new int[N];
            size = new int[N];
            for(int i = 0; i < N;i++)
            {
                parent[i] = i;
                size[i] = 1;
            }
        }

        public int find(int p)
        {
            while(p != parent[p])
            {
                parent[p] = parent[parent[p]]; //One-Pass Path Compression (Points to Grandparent)
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
            if(size[rootP] < size[rootQ])
            {
                parent[rootP] = rootQ;
                size[rootQ] += size[rootP];
            } 
            else
            {
                parent[rootQ] = rootP;
                size[rootP] += size[rootQ];
            }
            
            count--;
        }

        public void printList()
        {
            string p = ""; //parent array
            string s = ""; //size array
            for (int i = 0; i < parent.Length;i++)
            {
                p= p + parent[i] + " ";
                s = s + size[i] + " ";
            }
            Console.WriteLine(p);
            Console.WriteLine(s);
        }
    }
}