public class Student
{
    public string Id { get; }
    public string FullName { get; private set; }
    public double Gpa { get; private set; }

    public Student(string id, string fullName, double gpa)
    {
        if(string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("id can not be null or white space", nameof(id));
        }
        if(string.IsNullOrWhiteSpace(fullName))
        {
            throw new ArgumentException("fullName can not be null or white space", nameof(fullName));
        }
        if(gpa < 0 || gpa > 10)
        {
            throw new ArgumentException("gpa must be between 0 and 10", nameof(gpa));
        }
        Id = id;
        FullName = fullName;
        Gpa = gpa;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Id: {Id}, FullName: {FullName}, Gpa: {Gpa}");
    }
}
