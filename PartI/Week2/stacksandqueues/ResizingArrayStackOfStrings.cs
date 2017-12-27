using System;

namespace stacksandqueues
{
    class ResizingArrayStackOfStrings
    {
        private String[] s;
        private int N;

        public ResizingArrayStackOfStrings()
        {
            s = new String[1];
            N = 0;
        }

        public bool isEmpty() {return N == 0;}

        public void push(String item) 
        {
            if(N == s.Length)
            {
                resize(2 * s.Length);
            }
            s[N++] = item;
        }

        public String pop() {
            String item = s[--N];
            s[N] = null;
            if(N > 0 && N == s.Length/4)
            {
                resize(s.Length/2);
            }
            return item;
        }

        public int size() {return s.Length;}

        private void resize(int capacity)
        {
            String[] copy = new String[capacity];
            for(int i = 0; i < N; i++)
            {
                copy[i] = s[i];
            }
            s = copy;
        }
    }
}