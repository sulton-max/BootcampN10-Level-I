namespace N26;

public class TaskItem
{
    private string Name { get; set; }
    private int Priority { get; set; }


    public TaskItem(string name, int priority)
    {
        Name = name;
        Priority = priority;
    }

    public static bool operator >(TaskItem taskA, TaskItem taskB)
    {
        return taskA.Priority > taskB.Priority;
    }

    public static bool operator <(TaskItem taskA, TaskItem taskB)
    {
        return taskA.Priority < taskB.Priority;
    }

    public override string ToString()
    {
        return $"{Name} - {Priority}";
    }
}