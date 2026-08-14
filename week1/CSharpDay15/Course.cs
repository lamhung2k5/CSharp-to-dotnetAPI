public class Course
{ 
    public List<Student> Students { get; private set; }

    public Course(List<Student> students)
    {
        Students = students;
    }

    public void AddStudent(Student student)
    {
        if (student == null)
        {
            throw new ArgumentNullException(nameof(student), "Student cannot be null.");
        }
        Students.Add(student);
    }

    public void DisplayStudents()
    {
        foreach (var student in Students)
        {
            student.DisplayInfo();
        }
    }
}