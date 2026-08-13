public class Student
{
    public string Id { get; private set; }
    public string FullName { get; private set; }

    public Student(string id, string fullName)
    {
        if (string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("ID cannot be null or empty.", nameof(id));
        }
        if (string.IsNullOrWhiteSpace(fullName))
        {
            throw new ArgumentException("Full name cannot be null or empty.", nameof(fullName));
        }
        Id = id.Trim();
        FullName = fullName.Trim();
    }
}