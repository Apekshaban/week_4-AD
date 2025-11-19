public class Program
{
    public static void Main(string[] args)
    {
      
        Student student1 = new Student();
        Student student2 = new Student();

        
        student1.Name = "Alice Johnson";
        student1.RollNumber = 101;
        student1.GPA = 3.8;

        student2.Name = "Bob Williams";
        student2.RollNumber = 102;
        student2.GPA = 3.5;

        Student.SchoolName = "Metropolitan College";

        Console.WriteLine("--- Task 1: Student Objects ---");
        
        Console.WriteLine($"Student 1 Details: Name={student1.Name}, RollNo={student1.RollNumber}, GPA={student1.GPA}");
        Console.WriteLine($"Student 2 Details: Name={student2.Name}, RollNo={student2.RollNumber}, GPA={student2.GPA}");

        Console.WriteLine($"School Name (Static Field): {Student.SchoolName}");
        Console.WriteLine(new string('-', 30));
    }
}