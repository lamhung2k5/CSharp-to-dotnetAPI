public class NotificationService
{
    public void ShowRegistrationNotification(Registration registration)
    {
        Console.WriteLine($"Show Registration Notification: {registration.Student}, {registration.Course}");
    }
}