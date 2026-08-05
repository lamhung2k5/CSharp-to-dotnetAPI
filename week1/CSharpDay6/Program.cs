public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Product SP01 = new Product("SP01", "Laptop Dell", 20000000m, 3);
            SP01.Sell(7);
            SP01.DisplayInfo();
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine($"du lieu ko hop le: {ex.Message}");
        }
        catch(InvalidOperationException ex)
        {
            Console.WriteLine($"loi hoat dong: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"loi khac: {ex.Message}");
        }
    }
}