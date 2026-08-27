public class Employee
{
    public string? Id {get; set;}
    public string? FullName {get; set;}
    public decimal BaseSalary {get; set;}

    public Employee(string id, string fullname, decimal basesalary)
    {
        Id = id;
        FullName = fullname;
        BaseSalary = basesalary;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Full name: {FullName}, Base Salary: {BaseSalary}";
    }
}