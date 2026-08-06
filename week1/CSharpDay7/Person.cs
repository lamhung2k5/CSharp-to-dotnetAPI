public class Person
{
    public string Id { get; }
    public string FullName { get; private set; }
    public int Birthday { get; private set; }

    public Person(string id, string fullName, int birthday)
    {
        if(string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("id khong duoc de trong", nameof(id));
        }
        if(string.IsNullOrWhiteSpace(fullName)) 
        {
            throw new ArgumentException("ten khong duoc de trong", nameof(fullName));
        }
        if(birthday < 1900 || birthday > DateTime.Now.Year)
        {
            throw new ArgumentException("nam sinh khong hop le", nameof(birthday));
        }
        Id = id;
        FullName = fullName;
        Birthday = birthday;
    }

    public int CalculateAge()
    {
        return DateTime.Now.Year - Birthday;
    }

    public virtual void DisplayBasicInfo()
    {
        Console.WriteLine($"Id: {Id}, Full Name: {FullName}, Birthday: {Birthday}, Age: {CalculateAge()}");
    }
}