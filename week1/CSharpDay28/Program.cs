public class Program
{
    public static void Main(string[] args)
    {
        NotificationDelegate notification = NotificationService.SendEmail;
        notification += NotificationService.SendSms;
        notification += NotificationService.WriteLog;

        notification("Order completed");

        notification -= NotificationService.SendSms;
        notification("Payment completed");
    }
}