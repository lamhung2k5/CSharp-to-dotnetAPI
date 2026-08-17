public class Course
{
    public string Name { get; }
    private readonly List<Student> _students;

    public Course( string name, List<Student> students)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException(
                "Course name cannot be empty.",
                nameof(name));
        }

        if (students == null)
        {
            throw new ArgumentNullException(nameof(students));
        }

        Name = name.Trim();
        _students = students;
    }

    public void AddStudent(Student student)
    {
        if (student == null)
        {
            throw new ArgumentNullException(nameof(student));
        }

        _students.Add(student);
    }

    public void DisplayStudents()
    {
        Console.WriteLine($"Course: {Name}");

        foreach (Student student in _students)
        {
            student.DisplayInfo();
        }
    }
}