public class ProductSummary
{
    public string Name { get; }
    public decimal Price { get; }

    // constructor
    public ProductSummary(string name, decimal price)
    {
        if(string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("The Product summary name can noot be null or whitespace", nameof(name));
        }

        if(price <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(price), "Price must be greater than 0");
        }
        Name = name.Trim();
        Price = price;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Price: {Price}";
    }
}