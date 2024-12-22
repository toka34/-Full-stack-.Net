using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_09.Problem_2._2
{
    public class GenericStack<T>
    {
        private T[] _items;
        private int _top;
        private const int _initialCapacity = 4;

        public GenericStack()
        {
            _items = new T[_initialCapacity];
            _top = -1; // Stack is initially empty
        }

        // Push an item onto the stack
        public void Push(T item)
        {
            if (_top == _items.Length - 1)
            {
                Resize();
            }
            _items[++_top] = item;
        }

        // Pop an item from the stack
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return _items[_top--];
        }

        // Peek at the top item of the stack without removing it
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return _items[_top];
        }

        // Check if the stack is empty
        public bool IsEmpty()
        {
            return _top == -1;
        }

        // Resize the internal array when the stack is full
        private void Resize()
        {
            int newCapacity = _items.Length * 2;
            T[] newArray = new T[newCapacity];
            Array.Copy(_items, newArray, _items.Length);
            _items = newArray;
        }

        // Get the current count of items in the stack
        public int Count
        {
            get { return _top + 1; }
        }
    }
}
