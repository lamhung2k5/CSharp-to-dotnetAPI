public class Order
{
    public string Id { get; }
    public string CustomerName { get; private set; }
    public decimal TotalAmount { get; private set; }

    public Order(string id, string customerName, decimal totalAmount)
    {
        if(string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("Id cannot be null or whitespace", nameof(id));
        }
        if (string.IsNullOrWhiteSpace(customerName))
        {
            throw new ArgumentException("Customer name cannot be null or whitespace", nameof(customerName));
        }
        if (totalAmount < 0)
        {
            throw new ArgumentException("Total amount is invalid", nameof(totalAmount));
        }

        Id = id.Trim();
        CustomerName = customerName.Trim();
        TotalAmount = totalAmount;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Id: {Id}, Customer name: {CustomerName}, Total Amount: {TotalAmount}");
    }
}