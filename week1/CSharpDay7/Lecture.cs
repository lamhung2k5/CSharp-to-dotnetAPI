public class Lecture : Person
{
    public string EmployeeCode { get; }
    public string Derpartment { get; private set; }
    public decimal BaseSalery { get; private set; }

    public Lecture(string id, string fullName, int birthday, string employeeCode, string derpartment, decimal baseSalery) : base(id, fullName, birthday)
    {
        if(string.IsNullOrWhiteSpace(employeeCode))
        {
            throw new ArgumentException("ma giang vien khong duoc de trong", nameof(employeeCode));
        }
        if(string .IsNullOrWhiteSpace(derpartment))
        {
            throw new ArgumentException("ten bo mon khong duoc de trong", nameof(derpartment));
        }
        if(baseSalery <= 0)
        {
            throw new ArgumentException("luong co ban khong hop le", nameof(baseSalery));
        }

        EmployeeCode = employeeCode.Trim(); 
        Derpartment = derpartment.Trim();
        BaseSalery = baseSalery;
    }

    public void DisplayLectureInfo()
    {
        base.DisplayBasicInfo();
        Console.WriteLine($"Employee Code: {EmployeeCode}, Derpartment: {Derpartment}, Base Salery: {BaseSalery}");
    }

}