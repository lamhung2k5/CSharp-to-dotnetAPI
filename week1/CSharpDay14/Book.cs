public class Book
{
    public string Id { get; private set; }
    public string Title { get; private set; }
    public string Author { get; private set; }
    public Book(string id, string title, string author)
    {
        if (string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("ID cannot be null or empty.", nameof(id));
        }
        if (string.IsNullOrWhiteSpace(title))
        {
            throw new ArgumentException("Title cannot be null or empty.", nameof(title));
        }
        if (string.IsNullOrWhiteSpace(author))
        {
            throw new ArgumentException("Author cannot be null or empty.", nameof(author));
        }
        Id = id.Trim();
        Title = title.Trim();
        Author = author.Trim();
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Book ID: {Id}, Title: {Title}, Author: {Author}");
    }
}