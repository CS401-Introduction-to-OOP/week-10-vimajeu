namespace week10;

public class Character
{
    public string Name { get; }
    public string Role { get; }
    public int Level { get; }
    public int Health { get; }
    public string State { get; }

    public Character(string name, string role, int lvl, int health, string state)
    {
        Name = name;
        Role = role;
        Level = lvl;
        Health = health;
        State = state;
    }
    
}