public class Product
{
    public string Id { get; }
    public string Name { get; }
    public string CategoryId { get; }
    public decimal Price { get; }
    public int Stock { get; }

    public Product(
        string id,
        string name,
        string categoryId,
        decimal price,
        int stock)
    {
        Id = id;
        Name = name;
        CategoryId = categoryId;
        Price = price;
        Stock = stock;
    }

    public override string ToString()
    {
        return $"{Id} - {Name} - {Price} - Stock: {Stock}";
    }
}