namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("--- Task 2: Calculator Methods ---");
            Calculator calc = new Calculator();

            
            calc.PrintWelcome();

             
            int sum = calc.Add(10, 5);
            Console.WriteLine($"Addition of 10 and 5 is: {sum}");

           
            int product1 = calc.Multiply(8, 4);
            Console.WriteLine($"Multiplication of 8 and 4 is: {product1}");

        
            int product2 = calc.Multiply(7);
            Console.WriteLine($"Multiplication of 7 and default (1) is: {product2}");
            Console.WriteLine(new string('-', 30));
        }
    }
}
