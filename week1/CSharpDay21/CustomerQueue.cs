public class CustomerQueue
{
    private readonly Queue<string> _customers;

    public CustomerQueue()
    {
        _customers = new Queue<string>();
    }

    public void AddCustomer(string customerName)
    {
        if(customerName == null)
        {
            throw new ArgumentNullException(nameof(customerName), "Customer name cannot be null.");
        }

        _customers.Enqueue(customerName);
    }

    public string? ViewNextCustomer()
    {
        if(_customers.TryPeek(out string? customer))
        {
            return customer;
        }

        return null;
    }

    public string? ServeNextCustomer()
    {
        if(_customers.TryDequeue(out string? customer))
        {
            return customer;
        }

        return null;
    }

    public int GetWaitingCount()
    {
        return _customers.Count;
    }
    public void DisplayCustomers()
    {
        if(_customers.Count == 0)
        {
            Console.WriteLine("There are no customers.");
            return;
        }

        foreach(string customer in _customers) 
        {
            Console.WriteLine(customer);
        }
    }
}