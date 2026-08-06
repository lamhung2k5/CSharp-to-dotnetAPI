public abstract class  Employee
{
    public string Id { get; }
    public string FullName { get; private set; }
    public decimal BaseSalary { get; private set; }

    protected Employee(string id, string fullName, decimal baseSalary)
    {
        if(string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("id khong duoc de trong hoac null", nameof(id));
        }
        if(string.IsNullOrWhiteSpace(fullName))
        {
            throw new ArgumentException("ten khong duoc de trong hoac null", nameof(fullName));
        }
        if(baseSalary <= 0)
        {
            throw new ArgumentException("luong co ban phai lon hon 0", nameof(baseSalary));
        }
        Id = id;
        FullName = fullName;
        BaseSalary = baseSalary;
    }

    public abstract decimal CalculateSalary();

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Id: {Id}, FullName: {FullName}, BaseSalary: {BaseSalary:C}");
    }   
}