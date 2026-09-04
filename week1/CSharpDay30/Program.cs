public class Program
{
    public static void Main(string[] args)
    {
        Func<decimal, decimal, decimal> operation = Calculator.Add;
        Console.WriteLine(FuncProcessor.Process(10, 5, operation));

        operation = Calculator.Subtract;
        Console.WriteLine(FuncProcessor.Process(10, 5, operation));

        Console.WriteLine(FuncProcessor.Process(10, 5, Calculator.Multiply));

        Func<int, bool> checkAge = Person.IsAdult;

        Person person = new Person("John", 20);
        Console.WriteLine(person);
        Console.WriteLine(checkAge(person.Age));
    }
}