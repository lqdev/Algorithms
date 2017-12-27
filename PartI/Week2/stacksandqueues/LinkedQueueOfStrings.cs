using System;

namespace stacksandqueues
{
    class LinkedQueueOfStrings
    {
        private Node first,last;
        private int count;

        private class Node
        {
            public String item;
            public Node next;
        }

        public LinkedQueueOfStrings(){
            first = null;
            last = null;
        }

        public bool isEmpty()
        {
            return first == null;
        }

        public void enqueue(String item)
        {
            Node oldLast = last;
            last = new Node();
            last.item = item;
            last.next = null;
            if(isEmpty()) 
            {
                first = last;
            }
            else
            {
                oldLast.next = last;
            }
            count++;
        }

        public String dequeue()
        {
            String item = first.item;
            first = first.next;
            if(isEmpty()) last = null;
            count--;
            return item;
        }

        public int size()
        {
            return count;
        }
    }
    
}