public class Registration
{
    public string StudentId { get; }
    public string ObjectName { get; }

    public Registration(string studentId, string objectName)
    {
        if (string.IsNullOrWhiteSpace(studentId))
        {
            throw new ArgumentException("Id cannot be null or whitespace", nameof(studentId));
        }

        if (string.IsNullOrWhiteSpace(objectName))
        {
            throw new ArgumentException("Name cannot be null or whitespace", nameof(objectName));
        }

        StudentId = studentId.Trim();
        ObjectName = objectName.Trim();
    }

    public override string ToString()
    {
        return $"Id: {StudentId} Name: {ObjectName}";
    }
}