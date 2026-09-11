public class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student("SV01", "Nguyen Van A");
        Student student2 =new Student("SV02", "Tran Thi B");

        Course course1 = new Course("C01", "C# Programming",3, 500000);
        Course course2 = new Course("C02","Database",4,450000);
        Course course3 = new Course("C03","Web Development",3,600000);

        EmailService emailService = new EmailService();
        LogService logService = new LogService();
        NotificationService notificationService = new NotificationService();
        RegistrationService registrationService = new RegistrationService();

        registrationService.CourseRegistered += emailService.SendRegistrationEmail;
        registrationService.CourseRegistered += logService.WriteRegistrationLog;

        registrationService.AddStudent(student1);
        registrationService.AddStudent(student2);

        registrationService.AddCourse(course1);
        registrationService.AddCourse(course2);
        registrationService.AddCourse(course3);

        registrationService.RegisterCourse("SV01", "C01");

        Console.WriteLine("--------------------------------------------------------");
        registrationService.CourseRegistered += notificationService.ShowRegistrationNotification;

        registrationService.RegisterCourse("SV02","C02");

        Console.WriteLine("--------------------------------------------------------");
        registrationService.CourseRegistered -= emailService.SendRegistrationEmail;

        registrationService.RegisterCourse("SV01", "C03");

        Console.WriteLine("--------------------------------------------------------");
        try
        {
            registrationService.RegisterCourse("SV01","C01");
        }
        catch(InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


        try
        {
            registrationService.RegisterCourse("SV99","C01");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


        try
        {
            registrationService.RegisterCourse("SV01","C99");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            registrationService.RegisterCourse("   ","C01");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Func<Course, decimal> calculateFee = course => course.Credits * course.FeePerCredit;
        Console.WriteLine(calculateFee(course1));

        Registration sampleRegistration = new Registration(student1, course1);
        Action<Registration> displayRegistration = registration =>
        {
            Console.WriteLine($"Student: {registration.Student.FullName}");
            Console.WriteLine($"Course: {registration.Course.Name}");
            Console.WriteLine($"Credits: {registration.Course.Credits}");
            Console.WriteLine($"Registration at: {registration.RegisteredAt}");
        };

        displayRegistration(sampleRegistration);

        Console.WriteLine("----------------------");
        RegistrationMessageDelegate registrationMessageDelegate = RegistrationMessageService.ShowSuccessMessage;
        registrationMessageDelegate("Completed");
        Console.WriteLine("----------------------");
        registrationMessageDelegate += RegistrationMessageService.WriteConsoleMessage;
        registrationMessageDelegate("Completed");
    }
}