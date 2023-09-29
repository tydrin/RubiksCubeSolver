using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver
{
    public interface IQueue<T>
    {
        bool IsEmpty();
        bool IsFull();
        void Enqueue(T item);
        T Dequeue();
    }
    public interface IStack<T>
    {
        bool IsEmpty();
        bool IsFull();
        void Push(T item);
        T Pop();
        T Peek();
    }
    public class QUEUE<T> : IQueue<T>
    {
        private long size;
        private long maxsize;
        private long frontptr;
        private long rearptr;
        private T[] items;
        public QUEUE()
        {
            size = 0;
            maxsize = 2402889070804992000; // this is the worst case for one branch.
            frontptr = 0;
            rearptr = -1;
            items = new T[maxsize];
        }
        public bool IsEmpty()
        {
            if (size == 0) return true;
            else return false;
        }
        public bool IsFull()
        {
            if (size == maxsize) return true;
            else return false;
        }
        public void Enqueue(T item)
        {
            if (!IsFull())
            {
                size++;
                rearptr++;
                rearptr %= maxsize;
                items[rearptr] = item;
            }
            else throw new Exception("Error: The queue was full whilst trying to enqueue an item.");
        }
        public T Dequeue()
        {
            if (!IsEmpty())
            {
                size--;
                frontptr++;
                frontptr %= maxsize;
                return items[frontptr];
            }
            else throw new Exception("Error: The queue was empty whilst trying to dequeue an item.");
        }
    }
    public class STACK<T> : IStack<T>
    {
        private long size;
        private long maxsize;
        private long frontptr;
        private T[] items;
        public STACK()
        {
            size = 0;
            maxsize = 2402889070804992000;
            items = new T[maxsize];
        }
        public bool IsEmpty()
        {
            if (size == 0) return true;
            else return false;
        }
        public bool IsFull()
        {
            if (size == maxsize) return true;
            else return false;
        }
        public void Push(T item)
        {
            if (!IsFull())
            {
                size++;
                frontptr++;
                items[frontptr] = item;
            }
            else throw new Exception("Error: The stack was full when trying to push an item.");
        }
        public T Pop()
        {
            if (!IsEmpty())
            {
                size--;
                frontptr--;
                return items[frontptr];
            }
            else throw new Exception("Error: The stack was empty when trying to pop an item.");
        }
        public T Peek()
        {
            if (!IsEmpty())
            {
                return items[frontptr];
            }
            else throw new Exception("Error: The stack was empty when trying to peek an item.");
        }
    }
}
