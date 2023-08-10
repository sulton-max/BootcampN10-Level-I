using System.Collections;

namespace N22_T1.Models;

// Generic interfeys - qachonki klass ham generic bo'lsa

// Agar interfeysga generic parameter berilsa - generic methodlarni implement qilishi kerak bo'ladi
// Agar interfeysga aniq tip parameter berilsa - o'sha tipdagi methodlarni implement qilishi kerak bo'ladi

public class PriorityQueue<TEvent> : IEnumerable<TEvent>, IPriorityQueue<TEvent> where TEvent : ITaskEvent
{
    private readonly List<TEvent> _events = new();

    public void Enqueue(TEvent eventItem)
    {
        _events.Add(eventItem);
    }

    public TEvent Dequeue()
    {
        throw new NotImplementedException();
    }

    public TEvent Peek()
    {
        throw new NotImplementedException();
    }

    public IEnumerator<TEvent> GetEnumerator()
    {
        return _events.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _events.GetEnumerator();
    }
}