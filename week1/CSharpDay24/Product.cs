public class Product
{
    public string Id {  get;}
    public string Name { get; private set; }

    public Product(string id, string name)
    {
        if(string.IsNullOrWhiteSpace(id))
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

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}";
    }
}