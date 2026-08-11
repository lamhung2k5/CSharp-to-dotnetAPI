public class Program
{
    public static void Main(string[] args)
    {
        List<IPrintable> items = new List<IPrintable>
        {
            new Invoice(1001, "John Doe", 250.75m),
            new StudentCard("Alice Smith", 12345, "Computer Science"),
            new Invoice(1002, "Jane Doe", 150.50m),
            new StudentCard("Bob Johnson", 67890, "Mathematics")
        };

        foreach(IPrintable item in items)
        {
            item.Print();
        }
    }
}