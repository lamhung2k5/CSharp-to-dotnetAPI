public abstract class Person //lớp abstract
{
    public string Id { get; private set; }
    public string FullName { get; private set; }

    protected Person(string id, string fullName) //protected
    {
        if(string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("Id can not be null or white space", nameof(id));
        }

        if(string.IsNullOrWhiteSpace(fullName))
        {
            throw new ArgumentException("FullName can not be null or white space", nameof(fullName));
        }

        Id = id;
        FullName = fullName;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Id: {Id}, FullName: {FullName}");
    }
}