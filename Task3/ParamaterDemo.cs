public class ParameterDemo
{
  
    public void Increase(ref int number)
    {
        number += 10;
    }

  
    public void GetFullName(out string fullname)
    {
        fullname = "John David Smith"; // Assigning value to the out parameter [cite: 34]
    }

   
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}