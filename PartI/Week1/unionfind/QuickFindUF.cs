using System;

namespace unionfind
{
    class QuickFindUF
    {
        private int[] id;
        public int count { get; private set; }

        public QuickFindUF(int N) {
            count = N;
            id = new int[N];
            for(int i = 0; i < N; i++)
            {
                id[i] = i;
            }
        }
        public int find(int p)
        {
            return id[p];
        }

        public bool connected(int p, int q) {
            return find(p) == find(q);
        }

        public void union(int p, int q)
        {
            int pid = find(p);
            int qid = find(q);

            //If p and q both have the same value, then they are already conencted
            if(pid == qid) return; 

            //Connect p and q
            for(int i = 0; i < id.Length;i++)
            {
                if(id[i] == pid) {
                    id[i] = qid;
                }
            }
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