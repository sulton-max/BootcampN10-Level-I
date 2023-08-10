namespace N22_T1.Models;

public interface ITaskEvent
{
    Guid Id { get; }
    string Name { get; }
    byte Priority { get; }
}