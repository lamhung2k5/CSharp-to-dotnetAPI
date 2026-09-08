public class StudentService
{
    public event Action<string>? StudentRegistered;

    public void RegisterStudent(string studentName)
    {
        if(string.IsNullOrWhiteSpace(studentName))
        {
            throw new ArgumentException("student name cannot be null or whitespace", nameof(studentName));
        }

        string normalizedStudentName = studentName.Trim();

        Console.WriteLine($"Student {studentName}  registered successfully.");

        StudentRegistered?.Invoke(normalizedStudentName);
    }
}