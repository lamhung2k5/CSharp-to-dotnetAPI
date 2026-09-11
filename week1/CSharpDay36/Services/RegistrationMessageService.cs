public static class RegistrationMessageService
{
    public static void ShowSuccessMessage(string message)
    {
        Console.WriteLine($"SUCCESS: {message}");
    }

    public static void WriteConsoleMessage(string message)
    {
        Console.WriteLine($"MESSAGE: {message}");
    }
}