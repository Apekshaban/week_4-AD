namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();

            // Assign values to p1
            p1.playerName = "Apeksha Ban";
            p1.level = 16;
            p1.health = 2550;

            // using parameterized constructor
            Player p2 = new Player("John", 10, 2000);


            Console.WriteLine("\n");
            Console.WriteLine("Name: " + p1.playerName);
            Console.WriteLine("Level: " + p1.level);
            Console.WriteLine("Health: " + p1.health);

            Console.WriteLine("\n");
            Console.WriteLine("Name: " + p2.playerName);
            Console.WriteLine("Level: " + p2.level);
            Console.WriteLine("Health: " + p2.health);
        }
    }
}
