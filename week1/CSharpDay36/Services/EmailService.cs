public class EmailService
{
    public void SendRegistrationEmail(Registration registration)
    {
        Console.WriteLine($"Send Registration Email: {registration.Student}, {registration.Course}");
    }
}