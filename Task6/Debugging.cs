public class Debugging
{
    public void Calculate()
    {
        Console.Write("Enter marks: ");
        int.TryParse(Console.ReadLine(), out int marks);

        Console.Write("Enter total marks: ");
        int.TryParse(Console.ReadLine(), out int total);

        //setting one value to double for float division
        double percentage = (double)marks / total * 100;

        Console.WriteLine("Percentage: " + percentage);
    }
}