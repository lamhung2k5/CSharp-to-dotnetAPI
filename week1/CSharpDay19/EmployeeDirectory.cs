public class EmployeeDirectory
{
    public string Name { get; private set; }
    private readonly Dictionary<string, Employee> _employeeDirectory;

    public EmployeeDirectory(string name)
    {
        if(string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("name can not be null or white space", nameof(name));
        }

        Name = name.Trim();
        _employeeDirectory = new Dictionary<string, Employee>();
    }

    /*
    public void AddEmployee(Employee employee)
    {
        if(!_employeeDirectory.ContainsKey(employee.Id))
        {
            _employeeDirectory.Add(employee.Id, employee);
        }
        else
        {
            Console.WriteLine("emloyee is existing");
        }
    }*/
    public void AddEmployee(Employee employee)
    {
        if (employee == null)
        {
            throw new ArgumentNullException(nameof(employee),"Employee cannot be null.");
        }

        if (_employeeDirectory.ContainsKey(employee.Id))
        {
            throw new InvalidOperationException($"Employee with Id {employee.Id} already exists.");
        }

        _employeeDirectory.Add(employee.Id, employee);
    }

    /*
    public Employee FindEmployeeById(string id)
    {
        string normalizeId = id.Trim();
        
        if(string.IsNullOrWhiteSpace(normalizeId))
        {
            throw new ArgumentException("id can not be null or white space", nameof(normalizeId));
        }

        if(_employeeDirectory.TryGetValue(normalizeId, out Employee? employee))
        {
            return employee;
        }
        return null;
    }
    */
    public Employee? FindEmployeeById(string id)
    {
        //kiem tra id co null khong, sau do moi chuan hoa
        if (string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("Id cannot be null or whitespace.", nameof(id));
        }

        string normalizedId = id.Trim();

        if (_employeeDirectory.TryGetValue(normalizedId,out Employee? employee))
        {
            return employee;
        }

        return null;
    }


    public bool RemoveEmployeeById(string id)
    {
        //kiem tra id co null hay khong moi chuan hoa
        if (string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("id can not be null or white space", nameof(id));
        }

        string normalizeId = id.Trim();

        Employee removeEmployee = FindEmployeeById(normalizeId);
        /* bi du vi co the xoa truc tiep bang key nen khoi kiem tra
        if (removeEmployee == null)
        {
            return false;
        }
        */
        return _employeeDirectory.Remove(removeEmployee.Id);
    }

    public void DisplayEmployees()
    {
        if(_employeeDirectory.Count == 0)
        {
            Console.WriteLine("It's not element");
            return;
        }

        Console.WriteLine(Name);
        foreach(KeyValuePair<string, Employee> item in _employeeDirectory)
        {
            //hien luon ca key
            Console.WriteLine($"Dictionary key: {item.Key}");
            item.Value.DisplayInfo();
        }
    }
}