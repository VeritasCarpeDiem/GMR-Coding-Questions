using System;
using System.Collections.Generic;
using System.Text;

namespace CodingRiddles
{
    public class DS_14<S>
    {
        public class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Next { get; set; }

            public Node(T value)    
            {
                this.Value = value;
            }
        }
        public class LinkedList<T>
        {
            public Node<T> Head;
            public Node<T> tail;
            public int count { get; set; }
            public void AddLast(int value)
            {
                Node<T> temp = new Node<T>((T)(object)value);

                if (Head == null)
                {
                    Head = temp;
                    tail = temp;
                }
                else
                {
                    tail.Next = temp;
                    tail = temp;
                }
                count++;
            }
            public void DisplayList()
            {
                Node<T> current = Head;
                while (current != null)
                {
                    Console.Write($"{current.Value}->");
                    current = current.Next;
                }
                Console.Write("null");
           }
            public void ReverseLinkedList(ref Node<T> head)
            {
                Node<T> prev = null;
                Node<T> current = head;
                Node<T> next = null;

                while (current != null)
                {
                    next = current.Next;
                    current.Next = prev;
                    prev = current;
                    current = next;
                }
                head = prev;
            }          
        }
    }
}
