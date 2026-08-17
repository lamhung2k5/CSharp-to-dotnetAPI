public class Department
{
    public string Name { get; }
    private readonly List<Teacher> _teachers;

    public Department( string name, List<Teacher> teachers)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException(
                "Department name cannot be empty.",
                nameof(name));
        }

        if (teachers == null)
        {
            throw new ArgumentNullException(nameof(teachers));
        }

        Name = name.Trim();
        _teachers = teachers;
    }

    public void AddTeacher(Teacher teacher)
    {
        if (teacher == null)
        {
            throw new ArgumentNullException(nameof(teacher));
        }

        _teachers.Add(teacher);
    }

    public void DisplayTeachers()
    {
        Console.WriteLine($"Department: {Name}");

        foreach (Teacher teacher in _teachers)
        {
            teacher.DisplayInfo();
        }
    }
}