public class Program
{
    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
        {
            new OfficeEmployee("NV01", "Nguyen Van A", 10_000_000.00m, 20),
            new SalesEmployee("NV02", "Tran Thi B", 8_000_000.00m, 100_000_000.00m, 0.05m)
        };

        foreach(Employee e in employees)
        {
            e.DisplayInfo();
        }

        decimal TotalPayRoll = 0;
        foreach (Employee e in employees)
        {
            TotalPayRoll += e.CalculateSalary();
        }

        Console.WriteLine("Total Payroll: " + TotalPayRoll.ToString("C"));
    }
}
