public class PartTimeEmployee : Employee
{
    public decimal WorkingHours { get; private set; }
    public decimal HourlyRate { get; private set; }

    public PartTimeEmployee(string id, string fullName, decimal baseSalary, decimal workingHours, decimal hourlyRate) : base(id, fullName, baseSalary)
    {
    //khong biet co can kiem tra dieu kien khong, minh bo qua
        WorkingHours = workingHours;
        HourlyRate = hourlyRate;
    }

    public override decimal CalculateSalary()
    {
        return WorkingHours * HourlyRate;
    }



}