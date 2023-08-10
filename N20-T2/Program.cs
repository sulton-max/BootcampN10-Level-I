namespace N20_T2;

public class MyList<T>
{
    private T[] _items = new T[2];
    private long _lastIndex = 0;

    public void Add(T item)
    {
        EnsureCapacity();

        _items[_lastIndex] = item;
    }

    public void AddRange(IEnumerable<T> items)
    {
        EnsureCapacity((uint)items.Count());

        foreach (var item in items)
            Add(item);
    }

    private void EnsureCapacity(uint additionalCapacity = 1)
    {
        if (_lastIndex + additionalCapacity < _items.Length - 1) return;

        var newCapacity = GetNextSize(additionalCapacity);
        var newArray = new T[newCapacity];
        Array.Copy(_items, newArray, _items.Length);
        _items = newArray;
    }

    private int GetNextSize(in uint newItemsSize)
    {
        var newCapacity = _items.Length;
        do
        {
            newCapacity *= 2;
        } while (newCapacity < newItemsSize);

        return newCapacity;
    }
}