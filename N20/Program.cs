var list = new List<Task>();

// Inteface - klassdan farqi - multiple inheritance o'rnida ishlaydi
// nomida - I bilan boshlanadi
// memberlari - faqat methodlar va property

// Implement - inheritance dan farqi - e'lon qilingan methodni asosiy logikasini yozish

List
var queue = new PriorityQueue();
queue.Enqueue(new TaskItem());
queue.Enqueue(new EventItem());

public class PriorityQueue
{
    // public void Enqueue(ITaskEvent item)
    // {
    //     item.Priority
    // }

    public void Enqueue<T>(T item) where T : ITaskEvent, ICloneable
    {

        // item.Clone();
    }
}

// public interface IFileLocationService
// {
// }
//
// public interface IFileManagementService
// {
//     public void Write(Stream stream);
// }
//
// public class FileService : IFileLocationService, IFileManagementService
// {
//     public void Write(Stream stream)
//     {
//         // to'g'ridan to'g'ri yozib qo'yadi
//     }
// }
//
// public class ImageFileService : IFileManagementService
// {
//     public void Write(Stream stream)
//     {
//         // imageni qisqartirib, keyin yozadi
//     }
// }




public interface ITaskEvent
{
    string Name { get; }
    int Priority { get; }
}

public class TaskItem : ITaskEvent
{
    public string Name { get; set; }


    public int Priority { get; set; }

    public void DoSomething()
    {

    }


}

public class EventItem : ITaskEvent
{
    public string Name { get; set; }
    public int Priority { get; set; }


    public DateTime Date { get; set; }
}