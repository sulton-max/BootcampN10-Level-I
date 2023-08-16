namespace N22_T1.Models;

public interface ITaskEvent
{
    Guid Id { get; }
    string Name { get; }
    byte Priority { get; }


    void Display()
    {
Console.WriteLine($"Id: {Id}, Name: {Name}, Priority: {Priority}");
    }

    static bool operator <(ITaskEvent taskA, ITaskEvent taskB)
    {
        return taskA.Priority < taskB.Priority;
    }

    static bool operator >(ITaskEvent taskA, ITaskEvent taskB)
    {
        return taskA.Priority > taskB.Priority;
    }
}