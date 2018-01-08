using System;

namespace stacksandqueues
{
    public class GenericLinkedList<Item>
    {
        private Node first = null;

        private class Node
        {   
            public Item item;
            public Node next;
        }

        public bool isEmpty()
        {
            return first == null;
        }

        public void push(Item item)
        {
            Node oldFirst = first;
            first = new Node();
            first.item = item;
            first.next = oldFirst;
        }

        public Item pop()
        {
            Item item = first.item;
            first = first.next;
            return item;
        }
    }


}