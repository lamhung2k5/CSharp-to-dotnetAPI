public class Invoice : IPrintable
{
    public int InvoiceNumber { get; set; }
    public string CustomerName { get; set; }
    public decimal Amount { get; set; }

    public Invoice(int invoiceNumber, string customerName, decimal amount)
    {
        InvoiceNumber = invoiceNumber;
        CustomerName = customerName;
        Amount = amount;
    }

    public void Print()
    {
        Console.WriteLine($"Invoice Number: {InvoiceNumber}");
        Console.WriteLine($"Customer Name: {CustomerName}");
        Console.WriteLine($"Amount: {Amount:C}");
    }
}