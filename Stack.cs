using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class Stack<T>
    {
        private List<T> _list;

        public Stack()
        {
            _list = new List<T>();
        }

        public void Push(T item)
        {
            _list.Add(item);
        }

        public T Pop()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            var poppedItem = _list.Last();
            _list.RemoveAt(_list.Count - 1);
            return poppedItem;
        }

        public int Size()
        {
            return _list.Count;
        }

        public bool IsEmpty()
        {
            return _list.Count == 0;
        }
    }
}
