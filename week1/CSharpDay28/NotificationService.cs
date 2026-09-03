public static class NotificationService
{
    public static void SendEmail(string message)
    {
        Console.WriteLine($"email: {message}");
    }

    public static void SendSms(string message)
    {
        Console.WriteLine($"sms: {message}");
    }

    public static void WriteLog(string message)
    {
        Console.WriteLine($"log: {message}");
    }
}