using System;

namespace stacksandqueues
{
    class FixedCapacityOfStrings
    {
        private String[] s;
        private int N;

        public FixedCapacityOfStrings(int capacity)
        {
            s = new String[capacity];
            N = 0;
        }

        public bool isEmpty() {return N == 0;}
        public void push(String item) {s[N++] = item;}
        public String pop() {
            String item = s[--N];
            s[N] = null;
            return item;
        }
        public int size() {return s.Length;}
    }
}