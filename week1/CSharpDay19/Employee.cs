public class Employee
{
    public string Id { get; }
    public string Name { get; private set; }

    public Employee(string id, string name)
    {
        if(string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("Id cannot be null or whitespace", nameof(id));
        }

        if(string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be null or whitespace", nameof(name));
        }

        Id = id.Trim();
        Name = name.Trim();
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"id: {Id}, name: {Name}");
    }
}