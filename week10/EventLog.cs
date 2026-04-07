using System.Collections;

namespace week10;

public class EventLog : IEnumerable<Event>
{
    private List<Event> events = new();

    public IEnumerator<Event> GetEnumerator()
    {
        var sorted = events.OrderBy(e => e.Step);
        foreach (var e in sorted)
        {
            yield return e;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void Add(Event ev) => events.Add(ev);

}