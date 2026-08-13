public class Teacher
{
    public string Id { get; private set; }
    public string FullName { get; private set;}

    public Teacher(string id, string fullName)
    {
        if(string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("ID cannot be null or empty.", nameof(id));
        }
        if(string.IsNullOrWhiteSpace(fullName))
        {
            throw new ArgumentException("Full name cannot be null or empty.", nameof(fullName));
        }
        Id = id;
        FullName = fullName;
    }

    public void Teach(Student student, string topic)
    {
        Console.WriteLine($"Giang vien {FullName} dang day {topic} cho sinh vien {student.FullName}");
    }
}