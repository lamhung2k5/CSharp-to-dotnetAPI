public class Product
{
    public string Id { get; }
    public string Name { get; }
    public decimal Price { get; }

    // Constructor + validation
    public Product(string id, string name, decimal price)
    {
        if(string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("Id cannot be null or whitespace", nameof(id));
        }

        if(string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be null or whitespace", nameof(name));
        }

        if(price <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(price), "Price must be greater than 0.");
        }

        Id = id.Trim();
        Name = name.Trim();
        Price = price;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Id: {Id}, name: {Name}, Price: {Price}");
    }

    public override string ToString()
    {
        return $"Id: {Id}, name: {Name}, Price: {Price}";
    }
}