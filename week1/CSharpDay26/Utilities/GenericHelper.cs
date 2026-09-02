public static class GenericHelper
{
    public static void DisplayValue<T>(string label, T value)
    {
        Console.WriteLine($"{label} : {value}");
    }
}