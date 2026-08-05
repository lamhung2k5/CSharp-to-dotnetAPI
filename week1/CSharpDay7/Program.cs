public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Student s1 = new Student("1", "Nguyen Van A", 1800, "SV001", 8m);
            Lecture l1 = new Lecture("2", "Tran Thi B", 1980, "GV001", "CNTT", 15_000_000m);
            s1.DisplayStudentInfo();
            l1.DisplayLectureInfo();
        }  
        catch(ArgumentException ex)
        {
            Console.WriteLine($"du lieu ko hop le: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"loi khac: {ex.Message}");
        }
    }
}