public class Program
{
    public static void Main(string[] args)
    {
        EmployeeDirectory employeeDirectory = new EmployeeDirectory("DS nhan su cong ty");

        Employee e1 = new Employee("NV01", "hung");
        Employee e2 = new Employee("NV02", "ngan");
        Employee e3 = new Employee("NV03", "khanh");
        Employee e4 = new Employee("NV04", "manh");

        employeeDirectory.AddEmployee(e1);
        employeeDirectory.AddEmployee(e2);
        employeeDirectory.AddEmployee(e3);
        employeeDirectory.AddEmployee(e4);

        employeeDirectory.DisplayEmployees();

        
        Employee? foundEmployee = employeeDirectory.FindEmployeeById("NV09");

        if(foundEmployee == null)
        {
            Console.WriteLine("khong tim thay nhan vien");
        }
        else
        {
            Console.WriteLine("nhan vien can tim: ");
            foundEmployee.DisplayInfo();
        }
        
        //da thu tim va khong tim duoc id can xoa, chay dung yeu cau    
        if(employeeDirectory.RemoveEmployeeById("NV01") == false)
        {
            Console.WriteLine("khong co nhan vien can tim de xoa");
        }
        employeeDirectory.DisplayEmployees();

        Employee e5 = new Employee("NV04", "dung");
        employeeDirectory.AddEmployee(e5);
    }
}