public class OfficeEmployee : Employee
{
    public decimal OvertimeHours {get; set;}

    public OfficeEmployee(string id, string fullname, decimal basesalary, decimal overtimehours) : base(id, fullname, basesalary)
    {
        OvertimeHours = overtimehours;
    }

    public override decimal CalculateSalary()
    {
        return BaseSalary + OvertimeHours * 100000;
    }
}