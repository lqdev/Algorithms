using System;

namespace stacksandqueues
{
    public class LinkedStackOfStrings
    {
        
        private class Node {
                public String item;
                public Node next;
        }

        private Node first = null;
        private int count = 0;

        public bool isEmpty()
        {
            return first == null;
        }

        public void push(String item)
        {
            Node tmp = first;
            first = new Node();
            first.item = item;
            first.next = tmp;
            count++;
        }

        public String pop()
        {
            String item = first.item;
            first = first.next;
            return item;
            count--;
        }

        public int size()
        {
            return count;
        }
    }
    
}