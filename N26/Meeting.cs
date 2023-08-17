namespace N26;

public class Meeting
{
    public string Name { get; set; }
    public TimeSpan Duration { get; set; }

    public Meeting(string name, TimeSpan duration)
    {
        Name = name;
        Duration = duration;
    }

    public static TimeSpan operator +(TimeSpan timeSpan, Meeting meeting)
    {
        return timeSpan + meeting.Duration;
    }
}