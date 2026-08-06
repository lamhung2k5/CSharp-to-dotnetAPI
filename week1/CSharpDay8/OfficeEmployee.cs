public class OfficeEmployee : Employee
{
    public decimal OvertimeHours { get; private set; }

    public OfficeEmployee(string id, string fullName, decimal baseSalary, decimal overtimeHours) : base(id, fullName, baseSalary)
    {
        if (overtimeHours < 0)
        {
            throw new ArgumentException("So gio lam them khong duoc am", nameof(overtimeHours));
        }
        OvertimeHours = overtimeHours;
    }

    public override decimal CalculateSalary()
    {
        decimal overtimeRate = 100_000m; // Muc luong cho moi gio lam them
        return BaseSalary + (OvertimeHours * overtimeRate);
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Overtime Hours: {OvertimeHours}, Total Salary: {CalculateSalary():C}");
    }
}