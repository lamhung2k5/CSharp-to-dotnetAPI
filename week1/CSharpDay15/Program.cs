public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Student s1 = new Student(
    "P01",
    "Nguyen Van An",
    "SV001",
    "CARD001",
    new DateTime(2026, 8, 1));

            Student s2 = new Student(
                "P02",
                "Tran Thi Binh",
                "SV002",
                "CARD002",
                new DateTime(2026, 8, 2));

            Teacher t1 = new Teacher(
                "P03",
                "Le Van Cuong",
                "GV001");

            Teacher t2 = new Teacher(
                "P04",
                "Pham Thi Dung",
                "GV002");

            Department department = new Department(
                "Information Technology",
                new List<Teacher>
                {
        t1,
        t2
                });

            Course course = new Course(
                "C# Object-Oriented Programming",
                new List<Student>
                {
        s1,
        s2
                });

            t1.Teach(s1, "Inheritance");
            t2.Teach(s2, "Interface");

            department.DisplayTeachers();
            course.DisplayStudents();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}