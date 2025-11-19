public class Player
{
    // Instance fields
    public string playerName;
    public int level;
    public int health;

    // Default constructor
    public Player()
    {
        Console.WriteLine("Default constructor has been called");
    }

    // Parameterized constructor
    public Player(string name, int lvl, int hp)
    {
        playerName="Apeksha Ban";
        level = 15;
        health = 2500;
    }
}