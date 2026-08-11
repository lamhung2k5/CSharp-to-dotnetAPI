public class StudentCard : IPrintable
{
    public string StudentName { get; set; }
    public int StudentID { get; set; }
    public string Course { get; set; }
    public StudentCard(string studentName, int studentID, string course)
    {
        StudentName = studentName;
        StudentID = studentID;
        Course = course;
    }

    public void Print()
    {
        Console.WriteLine($"Student Name: {StudentName}");
        Console.WriteLine($"Student ID: {StudentID}");
        Console.WriteLine($"Course: {Course}");
    }
}