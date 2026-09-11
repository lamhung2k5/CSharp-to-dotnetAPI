public class LogService
{
    public void WriteRegistrationLog(Registration registration)
    {
        Console.WriteLine($"Write Registration Log: {registration.Student}, {registration.Course}");
    }
}