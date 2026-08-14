public abstract class Person
{
    public string Id { get; private set; }
    public string FullName { get; private set; }
    
    protected Person(string id, string fullName)
    {
        if(string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("Id cannot be null or whitespace.", nameof(id));
        }
        if(string.IsNullOrWhiteSpace(fullName))
        {
            throw new ArgumentException("FullName cannot be null or whitespace.", nameof(fullName));
        }
        Id = id;
        FullName = fullName;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}, Full Name: {FullName}");
    }
}