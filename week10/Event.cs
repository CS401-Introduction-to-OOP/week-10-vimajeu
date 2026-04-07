namespace week10;

public class Event
{
    public int Step { get; }
    public string Description { get; }
    public string EventType { get; }

    public Event(int step, string description, string type)
    {
        Step = step;
        Description = description;
        EventType = type;
    }
}