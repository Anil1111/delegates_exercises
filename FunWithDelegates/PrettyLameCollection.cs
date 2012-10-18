using System;
using System.Collections;

namespace FunWithDelegates
{
    public class PrettyLameCollection<T> : IEnumerable where T : IComparable<T>
    {
        private const int DefaultCapacity = 10;

        private readonly T[] _items;
        private int _currentSize;

        public PrettyLameCollection() : this(DefaultCapacity) {}

        public PrettyLameCollection(int capacity)
        {
            _items = new T[capacity];
        }

        public T this[int i]
        {
            get { return _items[i]; }
        }

        public void Add(T item)
        {
            _items[_currentSize++] = item;
        }

        public void Add(params T[] items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }

        public void Sort()
        {
            bool swapped;
            do
            {
                swapped = false;
                for (var i = 0; i < _currentSize - 1; i++)
                {
                    if (_items[i].CompareTo(_items[i + 1]) > 0)
                    {
                        SwapItems(i, i + 1);
                        swapped = true;
                    }
                }
            }
            while (swapped);
        }

        private void SwapItems(int index1, int index2)
        {
            var tempItem = _items[index1];
            _items[index1] = _items[index2];
            _items[index2] = tempItem;
        }

        public IEnumerator GetEnumerator()
        {
            var instanceArray = new T[_currentSize];
            for (int i = 0; i < _currentSize; i++)
            {
                instanceArray[i] = _items[i];
            }

            return  instanceArray.GetEnumerator();
        }
    }
}