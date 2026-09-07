public class Program
{
    public static void Main(string[] args)
    {
        OrderService order = new OrderService();

        order.OrderCompleted += NotificationService.SendEmail;

        order.OrderCompleted += NotificationService.WriteLog;

        order.CompleteOrder("DH01");

        order.OrderCompleted += NotificationService.ShowNotification;

        order.CompleteOrder("DH02");

        order.OrderCompleted -= NotificationService.SendEmail;

        order.CompleteOrder("DH03");
    }
}