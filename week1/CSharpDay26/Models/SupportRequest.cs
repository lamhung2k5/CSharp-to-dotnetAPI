public class SupportRequest : IEntity, IDisplayable
{
    public string Id { get; }
    public string StudentName { get; }
    public string Title { get; }
    public SupportCategory Category { get; }
    public DateTime CreatedAt { get; }
    public RequestStatus Status { get; private set; }

    //constructor
    public SupportRequest(string id, string studentName, string title, SupportCategory category)
    {
        ValidationString(id);
        ValidationString(studentName);
        ValidationString(title);

        Id = id.Trim();
        StudentName = studentName.Trim();
        Title = title.Trim();
        CreateAt = DateTime.Now;
        Category = category;
        Status = RequestStatus.Pending;
    }

    //validation string
    private void ValidationString(string str)
    {
        if (string.IsNullOrWhiteSpace(str))
        {
            throw new ArgumentException("String cannot be null or whitespace.");
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Student Name: {StudentName}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Category: {Category}");
        Console.WriteLine($"Created At: {CreateAt}");
        Console.WriteLine($"Status: {Status}");
    }

    public void MarkAsCompleted()
    {
        if(Status == RequestStatus.Completed)
        {
            throw new InvalidOperationException("This status is completed.");
        }

        Status = RequestStatus.Completed;
    }

    //hoan tac
    public void MarkAsPending()
    {
        Status = RequestStatus.Pending;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Student Name: {StudentName}, Title: {Title}, Category: {Category}, Created At: {CreateAt}, Status: {Status} ";
    }
}
