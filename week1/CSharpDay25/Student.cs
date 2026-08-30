public class Student : IEntity, IDisplayable
{
    public string Id { get; }
    public string FullName { get; }

    public Student(string id, string fullName)
    {
        if (string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("Id cannot be null or whitespace.", nameof(id));
        }

        if (string.IsNullOrWhiteSpace(fullName))
        {
            throw new ArgumentException("Name cannot be null or whitespace.", nameof(fullName));
        }

        Id = id.Trim();
        FullName = fullName.Trim();
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Student Id: {Id}, student full name: {FullName}");
    }
}