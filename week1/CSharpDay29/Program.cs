public class Program
{
    public static void Main(string[] args)
    {
        //khai bao Action<string> notification tro toi SendEmail
        Action<string> notification = NotificationService.SendEmail;

        //2.Gọi notification("Hello").
        notification("Hello");

        //3.Đổi notification sang SendSms rồi gọi lại.
        notification = NotificationService.SendSms;
        notification("Hello");

        //4.Thêm WriteLog bằng += để kiểm tra multicast.
        notification += NotificationService.WriteLog;
        notification("Hello");

        //5.Gọi ActionProcessor.Process("Order completed", NotificationService.SendEmail).
        ActionProcessor.Process("Order completed", NotificationService.SendEmail);

        //6.Gọi Process() lần nữa, nhưng truyền WriteLog.
        ActionProcessor.Process("Order completed", NotificationService.WriteLog);
    }
}