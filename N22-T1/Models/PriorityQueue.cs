using System.Collections;

namespace N22_T1.Models;

// Generic interfeys - qachonki klass ham generic bo'lsa

// Agar interfeysga generic parameter berilsa - generic methodlarni implement qilishi kerak bo'ladi
// Agar interfeysga aniq tip parameter berilsa - o'sha tipdagi methodlarni implement qilishi kerak bo'ladi

public  class Test
{
    public static bool operator <(Test taskA, Test taskB)
    {

    }
}

public class PriorityQueue<TItem> : IEnumerable<TItem>, IPriorityQueue<TItem> where TItem : ITaskEvent, ICloneable
{
    private readonly List<TItem> _events = new();

    public void Enqueue(TItem eventItem)
    {
        _events.Add(eventItem);
    }

    public TItem Dequeue()
    {
        _events[0] >

        var item= _events.Count > 0
            ? _events.MaxBy(item => item.Priority)
            : throw new InvalidOperationException("Queue is empty");

        _events.Remove(item);
        return item;

        // Eski usul
        // if (_events.Count == 0)
        //     throw new InvalidOperationException("Queue is empty");
        //
        // var maxPriorityEvent = _events[0];
        // foreach(var item in _events)
        // {
        //     if (item.Priority > maxPriorityEvent.Priority)
        //         maxPriorityEvent = item;
        // }
        //
        // _events.Remove(maxPriorityEvent);
        // return maxPriorityEvent;
    }

    public TItem Peek()
    {
        return _events.Count > 0
            ? _events.MaxBy(item => item.Priority)
            : throw new InvalidOperationException("Queue is empty");

        // Eski usul

        // if (_events.Count == 0)
        //     throw new InvalidOperationException("Queue is empty");
        //
        // var maxPriorityEvent = _events[0];
        // foreach(var item in _events)
        // {
        //     if (item.Priority > maxPriorityEvent.Priority)
        //         maxPriorityEvent = item;
        // }
        //
        // return maxPriorityEvent;
    }

    public IEnumerator<TItem> GetEnumerator()
    {
        return _events.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _events.GetEnumerator();
    }
}