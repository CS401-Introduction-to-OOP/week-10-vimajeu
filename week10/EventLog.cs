using System.Collections;

namespace week10;

public class EventLog : IEnumerable<Event>
{
    private List<Event> events = new();

    public IEnumerator<Event> GetEnumerator()
    {
        foreach (var e in events.OrderBy(e => e.Step))
        {
            yield return e;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void Add(Event ev) => events.Add(ev);

    public IEnumerable<Event> GetEventsType(string type)
    {
        foreach (var e in events)
        {
            if (e.EventType == type)
            {
                yield return e;
            }
        }
    }

    public IEnumerable<Event> LastEvents(int amount)
    {
        var sorted = events.OrderByDescending(e => e.Step).Take(amount).OrderBy(e => e.Step);
        foreach (var e in sorted)
        {
            yield return e;
        }
    }
    
}