public abstract class Employee
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

    public abstract decimal CalculateSalary();

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"id: {Id}, name: {FullName}, Base salary: {BaseSalary}");   
    }
}