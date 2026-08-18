public class Product
{
    public string Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

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
        Id = id;    
        Name = name;
        Price = price;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Product: {Name} (ID: {Id}), Price: ${Price:F2}");
    }
}