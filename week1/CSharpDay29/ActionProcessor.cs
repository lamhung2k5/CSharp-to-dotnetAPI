public static class ActionProcessor
{
    public static void Process(string message, Action<string> action)
    {
        action(message);
    }
}