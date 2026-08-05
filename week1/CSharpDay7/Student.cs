public class Student : Person

{
    public string StudentCode { get; }
    public decimal Gpa { get; private set; }

    public Student(string id, string fullName, int birthday, string studentCode, decimal gpa) : base(id, fullName, birthday)
    {
        if(string.IsNullOrWhiteSpace(studentCode))
        {
            throw new ArgumentException("ma sinh vien khong duoc de trong", nameof(studentCode));
        }
        if (gpa < 0 || gpa > 10)
        {
            throw new ArgumentException("gpa khong hop le", nameof(gpa));
        }
        StudentCode = studentCode;
        Gpa = gpa;
    }

    public void DisplayStudentInfo()
    {
        base.DisplayBasicInfo();
        Console.WriteLine($"Student Code: {StudentCode}, GPA: {Gpa}");
    }
}