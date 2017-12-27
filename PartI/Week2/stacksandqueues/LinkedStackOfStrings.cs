using System;

namespace stacksandqueues
{
    public class LinkedStackOfStrings
    {
        
        private Node first;
        private int count;

        private class Node {
            public String item;
            public Node next;
        }

        public LinkedStackOfStrings()
        {
            first = null;
            count = 0;
        }

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
            count--;
            return item;
            
        }

        public int size()
        {
            return count;
        }
    }
    
}