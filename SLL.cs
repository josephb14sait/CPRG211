using Assignment3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment3
{
    [Serializable]
    public class SLL : ILinkedListADT
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int counter;

        public SLL()
        {
            Head = null;
            Tail = null;
            counter = 0;
        }

        public void Add(User data, int index)
        {
            if (index < 0 || index > counter)
                throw new IndexOutOfRangeException("Index is out of range.");

            if (index == 0)
            {
                AddFirst(data);
            }
            else if (index == counter)
            {
                AddLast(data);
            }
            else
            {
                Node newNode = new Node(data);
                Node current = Head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                current.Next = newNode;
                counter++;
            }
        }

        public void AddFirst(User data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;

            }

            else
            {
                newNode.Next = Head;
                Head = newNode;
            }

            counter++;
        }

        public void AddLast(User data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Tail.Next = newNode;
            }
            Tail = newNode;
            counter++;
        }

        public void Replace(User data, int index)
        {
            if (index < 0 || index >= counter)
                throw new IndexOutOfRangeException("Index is out of range.");

            Node current = Head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            current.Value = data;
        }

        public int Count()
        {
            return counter;
        }

        public User GetValue(int index)
        {
            if (index < 0 || index >= counter)
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

            Node current = Head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Value;
        }

        public int IndexOf(User value)
        {
            Node current = Head;
            int index = 0;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1;
        }

        public bool Contains(User value)
        {
            return IndexOf(value) != -1;
        } 

        public bool IsEmpty()
        {
            return counter == 0;
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            counter = 0;
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= counter)
                throw new IndexOutOfRangeException("Index is out of range.");

            if (index == 0)
            {
                RemoveFirst();
            }
            else if (index == counter - 1)
            {
                RemoveLast();
            }
            else
            {
                Node current = Head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                current.Next = current.Next.Next;
                counter--;
            }
        }

        public void RemoveFirst()
        {
            if (Head != null)
            {
                Head = Head.Next;
                if (Head == null)
                {
                    Tail = null;
                }
                counter--;
            }
            else
            {
                Console.WriteLine("List is already empty.");
            }
        }

        public void RemoveLast()
        {
            if (Head == null)
            {
                Console.WriteLine("List is already empty.");
                return;
            }
            if (Head.Next == null)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Node current = Head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
                Tail = current;
            }
            counter--;
        }
        //Added Linked List To Array Method
        public User[] ListToArray()
        {
            User[] array = new User[counter];

            Node current = Head;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = current.Value;
                current = current.Next;
            }

            return array;
        }

    }
}
