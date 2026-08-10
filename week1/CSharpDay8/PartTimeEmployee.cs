public class PartTimeEmployee : Employee
{
    public decimal WorkingHours { get; private set; }
    public decimal HourlyRate { get; private set; }

    public PartTimeEmployee(string id, string fullName, decimal baseSalary, decimal workingHours, decimal hourlyRate) : base(id, fullName, baseSalary)
    {
    //khong biet co can kiem tra dieu kien khong, minh bo qua
        if(workingHours <= 0)
        {
            throw new ArgumentException("so gio lam khong nho hon bang 0", nameof(workingHours));
        }

        if(hourlyRate <= 0)
        {
            throw new ArgumentException("luong  khong nho hon bang 0", nameof(hourlyRate));
        }
        WorkingHours = workingHours;
        HourlyRate = hourlyRate;
    }

    public override decimal CalculateSalary()
    {
        return WorkingHours * HourlyRate;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Full Name: {FullName}");
        Console.WriteLine($"Working Hours: {WorkingHours}");
        Console.WriteLine($"Hourly Rate: {HourlyRate:N0} đồng");
        Console.WriteLine(
            $"Total Salary: {CalculateSalary():N0} đồng");
    }


}