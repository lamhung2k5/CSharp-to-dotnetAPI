public class Product
{
    public string Id { get; }
    public string Name { get; private set; }
    public decimal Price { get; private set; }

    public Product(string id, string name, decimal price)
    {
        if(string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("id can not be null or whitespace", nameof(id));
        }
        if(string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("name can not be null or whitespace", nameof(name));
        }
        if(price <= 0)
        {
            throw new ArgumentException("price must be a positive number", nameof(price));
        }
        Id = id.Trim();    
        Name = name.Trim();
        Price = price;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Product: {Name} (ID: {Id}), Price: ${Price:F2}");
    }
}