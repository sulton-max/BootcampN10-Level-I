namespace N30.Models;

public class Message
{
    public Guid Id { get; set; }
    public string Body { get; set; }
    
    public Message(string body)
    {
        Id = Guid.NewGuid();
        Body = body;
    }

}