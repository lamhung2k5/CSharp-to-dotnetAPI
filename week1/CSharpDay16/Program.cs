public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Student student1 = new Student("P01", "Nguyen Van An", "SV001", "CARD001", "2026-08-01");
            Student student2 = new Student("P02", "Nguyen van binh", "SV002", "CARD002", "2026-08-02");
            Student student3 = new Student("P03", "Lam Tan Dung", "SV003", "CARD003", "2026-08-03");
            List<Student> students = new List<Student>();

            Course CSharpCourse = new Course(students);
            CSharpCourse.AddStudent(student1);
            CSharpCourse.AddStudent(student2);
            CSharpCourse.AddStudent(student3);

            CSharpCourse.DisplayStudents();

            /*student.DisplayInfo();
            Teacher teacher1 = new Teacher("T01", "Le Thi B", "GV001");
            Teacher teacher2 = new Teacher("T02", "Tran Van C", "GV002");
            Teacher teacher3 = new Teacher("T03", "Nguyen Van D", "GV003");

            List<Teacher> teachers = new List<Teacher> { teacher1, teacher2, teacher3 };

            Deparment deparment = new Deparment(teachers);
            deparment.DisplayTeachers();*/
            
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}