public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Student s1 = new Student("1", "Nguyen Van A", 1990, "SV001", 8m);
            Student s2 = new Student("2", "Le Thi B", 1995, "SV002", 9m);
            Lecturer l1 = new Lecturer("3", "Tran Thi B", 1980, "GV001", "CNTT", 15_000_000m);
            Lecturer l2 = new Lecturer("4", "Pham Van C", 1975, "GV002", "Toan", 20_000_000m);
            
            List<Person> people = new List<Person>();
            people.Add(s1);
            people.Add(s2);
            people.Add(l1);
            people.Add(l2);

            foreach(Person p in people) 
            {
                p.DisplayBasicInfo();
                Console.WriteLine("--------------------");
            }
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