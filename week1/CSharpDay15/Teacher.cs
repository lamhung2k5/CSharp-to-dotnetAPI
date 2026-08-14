public class Teacher : Person
{
    public string EmployeeCode { get; private set; }

    public Teacher(string id, string fullName, string employeeCode) : base(id, fullName)
    {
        if (string.IsNullOrWhiteSpace(employeeCode))
        {
            throw new ArgumentException("Employee code cannot be null or whitespace.", nameof(employeeCode));
        }
        EmployeeCode = employeeCode.Trim();
    }

    public void Teach(Student student, string topic)
    {
        Console.WriteLine($"{FullName} is teaching {student.FullName} about {topic}.");
    }
}