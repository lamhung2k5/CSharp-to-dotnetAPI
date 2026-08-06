public class Lecturer : Person
{
    public string EmployeeCode { get; }
    public string Department { get; private set; }
    public decimal BaseSalary { get; private set; }

    public Lecturer(string id, string fullName, int birthday, string employeeCode, string department, decimal baseSalary) : base(id, fullName, birthday)
    {
        if(string.IsNullOrWhiteSpace(employeeCode))
        {
            throw new ArgumentException("ma giang vien khong duoc de trong", nameof(employeeCode));
        }
        if(string .IsNullOrWhiteSpace(department))
        {
            throw new ArgumentException("ten bo mon khong duoc de trong", nameof(department));
        }
        if(baseSalary <= 0)
        {
            throw new ArgumentException("luong co ban khong hop le", nameof(baseSalary));
        }

        EmployeeCode = employeeCode.Trim(); 
        Department = department.Trim();
        BaseSalary = baseSalary;
    }

    public override void DisplayBasicInfo()
    {
        base.DisplayBasicInfo();
        Console.WriteLine($"Employee Code: {EmployeeCode}, Department: {Department}, Base Salary: {BaseSalary}");
    }

}