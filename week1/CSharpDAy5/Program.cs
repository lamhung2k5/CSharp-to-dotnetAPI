public class Program
{
    public static void Main(String[] args)
    {
        Employee e = new Employee("11212","Hung",123456);
        e.DisplayInfo();
        Offf e1 = new OfficeEmployee("11212","Hung",123456,1212);
        e1.DisplayInfo();
    }
}