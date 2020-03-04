using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListImpl
{
    public class MyList<T> : IMyCollection<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }

        public int Count { get; private set; }

        public void Add(T value) => AddToLast(value);


        public void AddToFirst(T value)
        {
            Node<T> temp = Head;
            Head = new Node<T>(value)
            {
                Next = temp
            };

            if (Count == 0)
            {
                Tail = Head;
            }
            else
            {
                temp.Previous = Head;
            }
            Count++;
        }

        public void AddToLast(T value)
        {
            Node<T> node = new Node<T>(value);
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
            }
            Tail = node;
            Count++;
        }

        public void Clear()
        {
            Count = 0;
            Head = null;
            Tail = null;
        }



        public bool Remove(T value)
        {
            Node<T> previous = null;
            Node<T> current = Head;
            while (current != null)
            {

                if (current.Value.Equals(value))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                        {
                            Tail = previous;
                        }
                        else
                        {

                            current.Next.Previous = previous;
                        }
                        --Count;
                    }
                    else
                    {
                        RemoveFirst();
                    }

                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;

        }

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                Head = Head.Next;
                --Count;
                if (Count == 0)
                {
                    Tail = null;
                }
                else
                {
                    Head.Previous = null;
                }
            }
        }

        public void RemoveLast()
        {
            if (Count != 0)
            {

                Tail = Tail.Previous;
                --Count;
                if (Count == 0)
                {
                    Head = null;
                }
                else
                {
                    Tail.Next = null;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyList<T>().GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
    }
}
