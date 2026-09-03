public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Calculator.Add(2,4));
        Console.WriteLine(Calculator.Subtract(2,4));
        Console.WriteLine(Calculator.Multiply(2,4));
        Console.WriteLine(Calculator.Divide(2,4));
        try
        {
            Console.WriteLine(Calculator.Divide(2,0));
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine($"Zero value error: {ex.Message}");
        }

        //su dung suc manh cua delegate
        CalculateDelegate operation = Calculator.Add;
        decimal result = operation(1,2);
        Console.WriteLine(result);

        Console.WriteLine(Calculator.Calculate(1, 2, Calculator.Add));
    }
}