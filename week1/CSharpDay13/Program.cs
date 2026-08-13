public class Program
{
    public static void Main(string[] args)
    {
        Student s1 = new Student("S01", "An");
        Teacher t1 = new Teacher("T01", "Binh");

        t1.Teach(s1, "C#");
    }
}