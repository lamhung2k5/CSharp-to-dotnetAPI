public class Product : IEntity, IDisplayable
{
    public string Id { get; }
    public string Name { get; }

    public Product(string id, string name)
    {
        if (string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("Id cannot be null or whitespace.", nameof(id));
        }

        if(string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be null or whitespace.", nameof(name));
        }

        Id = id.Trim();
        Name = name.Trim();
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Product id: {Id}, Product Name: {Name}");
    }
}