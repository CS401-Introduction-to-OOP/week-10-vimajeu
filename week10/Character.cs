namespace week10;

public class Character
{
    public enum Status
    {
        Active,
        Nonactive
    }
    
    public string Name { get; }
    public string Role { get; }
    public int Level { get; }
    public int Health { get; }

    public Status State { get; private set; }

    public Character(string name, string role, int lvl, int health)
    {
        Name = name;
        Role = role;
        Level = lvl;
        Health = health;
        State = Status.Active;
    }

    public void ChangeCharacterStatus()
    {
        if (State == Status.Active)
        {
            State = Status.Nonactive;
        }
        else
        {
            State = Status.Active;
        }
    }

    public override string ToString() => $"Character: {Name}";
}