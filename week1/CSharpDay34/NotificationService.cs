public static class NotificationService
{
    public static void SendEmail(string email)
    {
        Console.WriteLine($"Send email: {email}");
    }

    public static void WriteLog(string sms)
    {
        Console.WriteLine($"Write log: {sms}");
    }

    public static void ShowNotification(string orderId)
    {
        Console.WriteLine($"Notificaiton: {orderId}");
    }
}