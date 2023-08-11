using System.Collections;

public class CustomQueryableCollection<T> : IEnumerable<T>
{
    private readonly List<T> _collection = new();
    private Func<T, bool> _predicate;

    public void Add(T item)
    {
        _collection.Add(item);
    }

    // queryni eslab qolmaydigan usul
    // predicate - delegatni turi va u bitta narsa qabul qilib, true yoki false qaytaradi
    public CustomQueryableCollection<T> Where(Func<T, bool> predicate)
    {
        _predicate = predicate;
        return this;
    }

    public IEnumerator<T> GetEnumerator()
    {
        var result = new List<T>();
        foreach(var item in _collection)
        {
            if(_predicate(item))
                result.Add(item);
        }

        return result.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}