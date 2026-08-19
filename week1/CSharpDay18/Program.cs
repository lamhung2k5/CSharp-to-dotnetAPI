public class Program
{
    public static void Main(string[] args)
    {
        StudentDirectory studentDirectory1 = new StudentDirectory("DA23TTA student directory");

        Student student1 = new Student("SV01", "Lam Tan Hung", 9.0);
        Student student2 = new Student("SV02", "Ly Nha Ky", 4.0);
        Student student3 = new Student("SV03", "Nguyen Phuong Hang", 6.0);

        studentDirectory1.AddStudent(student1);
        studentDirectory1.AddStudent(student2);
        studentDirectory1.AddStudent(student3);

        //hien thi toan bo sinh vien
        studentDirectory1.DisplayStudents();

        //tim sinh vien co id = "SV02"
        Student? foundStudent = studentDirectory1.FindStudentById("SV02");
        if(foundStudent == null)
        {
            Console.WriteLine("Student does not existed");
        }
        else
        {
            foundStudent.DisplayInfo();
        }
        //thu tim bang mot id khong ton tai
        Student? foundStudent2 = studentDirectory1.FindStudentById("SV09");
        if (foundStudent2 == null)
        {
            Console.WriteLine("Student does not existed");
        }
        else
        {
            foundStudent2.DisplayInfo();
        }

        //xoa id = "SV01"
        bool removed = studentDirectory1.RemoveStudentById("SV01");

        if (removed)
        {
            Console.WriteLine("Student removed successfully.");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }

        //them mot id bi trung
        try
        {
            Student student4 = new Student("SV03","Phan Van Mach",2.0);

            studentDirectory1.AddStudent(student4);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}