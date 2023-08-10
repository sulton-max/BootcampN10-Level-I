using N21.N21_T1;

var list = new MyList<int>();
list.Add(10);
list.Add(10);
list.Add(10);

list.AddRange(new[] {1,2,3});

namespace N21.N21_T1
{
    public class MyList<T>
    {
        private T[] _items = new T[2];
        private long _lastIndex = 0;

        public void Add(T item)
        {
            EnsureCapacity();

            _items[_lastIndex++] = item;
        }

        public void AddRange(IEnumerable<T> items)
        {
            EnsureCapacity((uint)items.Count());

            foreach (var item in items)
                _items[_lastIndex++] = item;
        }

        private void EnsureCapacity(uint additionalCapacity = 1)
        {
            if (_lastIndex + additionalCapacity < _items.Length) return;

            var newCapacity = GetNextSize((uint)_lastIndex + additionalCapacity);
            var newArray = new T[newCapacity];
            Array.Copy(_items, newArray, _items.Length);
            _items = newArray;
        }

        private uint GetNextSize(in uint desiredItemSize)
        {
            var newCapacity = desiredItemSize;
            do
            {
                newCapacity *= 2;
            } while (newCapacity < desiredItemSize);

            return newCapacity;
        }
    }
}