public static class FuncProcessor
{
    public static decimal Process(decimal first, decimal second, Func<decimal, decimal, decimal> operation)
    {
        return operation(first, second);
    }
}