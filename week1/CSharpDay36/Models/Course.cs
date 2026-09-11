public class Course
{
    public string Id { get; }

    public string Name { get; }

    public int Credits { get; } //tin chi

    public decimal FeePerCredit { get; } //hoc phi moi tin chi

    public Course(string id, string name, int credits, decimal feePerCredit)
    {
        if(string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("Id cannot be null or whitespace", nameof(id));
        }

        if(string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be null or whitespace.", nameof(name));
        }

        if(credits <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(credits), "Credits must be greater than 0.");
        }

        if (feePerCredit <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(feePerCredit), "Fee per Credits must be greater than 0.");
        }

        Id = id.Trim();
        Name = name.Trim();
        Credits = credits;
        FeePerCredit = feePerCredit;
    }
    
    public override string ToString()
    {
        return $"Id: {Id}, name: {Name}, Credits: {Credits}, Fee Per Credit: {FeePerCredit}";
    }
}