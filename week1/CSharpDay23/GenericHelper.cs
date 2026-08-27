public static class GenericHelper
{
    //Validation
    private static void ValidateList<T>(List<T> items)
    {
        if (items == null)
        {
            throw new ArgumentNullException(nameof(items), "The list cannot be null.");
        }

        if(items.Count == 0)
        {
            throw new InvalidOperationException("The list is empty.");
        }
    }

    //Display value 
    public static void DisplayValue<T>(T value)
    {
        Console.WriteLine($"type: {typeof(T).Name}, value: {value}");
    }

    //GetFirstValue
    public static T GetFirstItem<T>(List<T> items)
    {
        ValidateList(items);

        return items[0];
    }

    public static T GetLastItem<T>(List<T> items)
    {
        ValidateList(items);

        return items[items.Count - 1];
    }

    public static void SwapValues<T>(ref T first, ref T second)
    {
        T temp = first;
        first = second;
        second = temp;
    }

    public static bool AreValuesEqual<T>(T first, T second)
    {
        return EqualityComparer<T>.Default.Equals(first, second);
    }

    public static void DisplayKeyValue<TKey, TValue>(TKey key, TValue value)
    {
        Console.WriteLine($"Key type: {typeof(TKey).Name}, value: {key}");
        Console.WriteLine($"Value type: {typeof(TValue).Name}, value: {value}");
    }
}