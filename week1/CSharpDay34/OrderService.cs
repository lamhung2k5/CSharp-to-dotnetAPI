public class OrderService
{
    public event Action<string>? OrderCompleted;

    public void CompleteOrder(string orderId)
    {
        if(string.IsNullOrWhiteSpace(orderId))
        {
            throw new ArgumentException("Order Id cannot be null or whitespace");
        }

        string normalizedOrderId = orderId.Trim();

        Console.WriteLine("Order Completed");

        OrderCompleted?.Invoke(normalizedOrderId);
    }
}