public class Program
{
    public static void Main(string[] args)
    {
        //1.Tạo StudentService.
        StudentService studentService = new StudentService();

        //2.Tạo EmailService.
        EmailService emailService = new EmailService();

        //3.Tạo LogService.
        LogService logService = new LogService();

        //4.Tạo WelcomeNotificationService.
        WelcomeNotificationService welcomeNotificationService = new WelcomeNotificationService();

        //5.Đăng ký SendWelcomeEmail.
        studentService.StudentRegistered += emailService.SendWelcomeEmail;

        //6.Đăng ký WriteRegistrationLog.
        studentService.StudentRegistered += logService.WriteRegistrationLog;

        //7.RegisterStudent("Nguyen Van A").
        studentService.RegisterStudent("Nguyen van A");

        //8.Đăng ký thêm ShowWelcomeMessage.
        studentService.StudentRegistered += welcomeNotificationService.ShowWelcomeService;

        //9.RegisterStudent("Tran Thi B").
        studentService.RegisterStudent("Tran Thi B");
        
        //10.Hủy đăng ký SendWelcomeEmail.
        studentService.StudentRegistered -= emailService.SendWelcomeEmail;

        //11.RegisterStudent("Le Van C").
        studentService.RegisterStudent("Le Van C");
    }
}