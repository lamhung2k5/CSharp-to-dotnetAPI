public class Program
{
    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
        {
            // Một OfficeEmployee đủ điều kiện thưởng
            new OfficeEmployee("NV01", "Nguyen Van A", 10_000_000m, 25m),
            // Một SalesEmployee đủ điều kiện thưởng
            new SalesEmployee("NV02", "Tran Thi B",8_000_000m, 150_000_000m, 0.05m),
            // Một PartTimeEmployee không có thưởng
            new PartTimeEmployee("NV03","Le Van C", 1m, 120m, 60_000m)
        };

        foreach(Employee e in employees) 
        {
            e.DisplayInfo();
        }

        foreach (Employee employee in employees)
        {
            if (employee is IBonusEligible bonusEligible)
            {
                Console.WriteLine(
                    $"{employee.FullName} - " +
                    $"Bonus: {bonusEligible.CalculateBonus():N0} đồng");
            }
        }
    }
}
