using System.Collections;

namespace week10;

public class Party<T> : IEnumerable<T> where T : Character
{
    private List<Character> characters;

    public Party(List<Character> chars)
    {
        characters = chars;
    }
    
    public IEnumerator<T> GetEnumerator()
    {
        foreach (var character1 in characters)
        {
            var character = (T)character1;
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

    public void ShowAllCharacters()
    {
        foreach (var character in characters)
        {
            Console.WriteLine(character);
        }
    }
}