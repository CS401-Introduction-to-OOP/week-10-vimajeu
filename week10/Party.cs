using System.Collections;

namespace week10;

public class Party : IEnumerable<Character>
{
    private List<Character> characters = new();
    
    public IEnumerator<Character> GetEnumerator()
    {
        foreach (var character in characters)
        {
            yield return character;
        }
    }
    
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(Character character)
    {
        characters.Add(character);
    }

    public IEnumerable<Character> ShowAllActive()
    {
        foreach (var character in characters)
        {
            if (character.State == Character.Status.Active)
            {
                yield return character;
            }
        }
    }

    public IEnumerable<Character> ShowLowHp(int hp)
    {
        foreach (var character in characters)
        {
            if (character.Health < hp)
            {
                yield return character;
            }
        }
    }
    
}