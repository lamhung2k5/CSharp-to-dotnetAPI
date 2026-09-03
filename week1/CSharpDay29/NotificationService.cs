public static class NotificationService
{
    public static void SendEmail(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }

    public static void SendSms(string message)
    {
        Console.WriteLine($"SMS sent: {message}");
    }

    public static void WriteLog(string message)
    {
        Console.WriteLine($"Log written: {message}");
    }
}