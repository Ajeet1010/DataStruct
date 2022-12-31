using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructue
{
    public class LinkedList<T>
    {
        public Node<T> head;
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }

        public void Search(T value)
        {
            Node<T> temp = this.head;
            while (temp != null)
            {
                if (temp.data.Equals(value))
                {
                    Console.WriteLine("Searching number {0} is found", temp.data);
                    return;
                }
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine("Searched number {0} is not found", value);
                Add(value);
            }
        }

        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
