namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("--- Task 3: Parameter Types ---"); 
            ParameterDemo demo = new ParameterDemo();

          
            int value = 20;
            Console.WriteLine($"Original value before ref: {value}");
            demo.Increase(ref value);
            Console.WriteLine($"Value after Increase (ref): {value}"); // Should be 30

            
            string fullName;
            demo.GetFullName(out fullName);
            Console.WriteLine($"Full Name from GetFullName (out): {fullName}");

            
            int totalSum = demo.SumAll(1, 2, 3, 4, 5);
            Console.WriteLine($"Sum of numbers (params): {totalSum}");
            Console.WriteLine(new string('-', 30));
        }
    }
}
