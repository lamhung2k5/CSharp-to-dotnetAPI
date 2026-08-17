public class Teacher : Person
{
    public string EmployeeCode { get; private set; }

    public Teacher(string id, string fullName, string employeeCode) : base(id, fullName) //sửa lại protected
    {
        if(string.IsNullOrWhiteSpace(employeeCode))
        {
            throw new ArgumentException("EmployeeCode can not be null or white space", nameof(employeeCode));
        }
        EmployeeCode = employeeCode;
    }

    public void Teach(Student student, string topic)
    {
        if(student == null)
        {
            throw new ArgumentNullException(nameof(student), "Student can not be null");
        }
        if(string.IsNullOrWhiteSpace(topic))
        {
            throw new ArgumentException("Topic can not be null or white space", nameof(topic));
        }
        Console.WriteLine($"Teacher {base.FullName} is teaching {student.FullName} about {topic}");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"EmployeeCode: {EmployeeCode}");
    }
}