public class Book
{
    public string Id { get; }
    public string Title { get; }
    public string Author { get; }

    public Book(string id, string title, string author)
    {
        if(string.IsNullOrWhiteSpace(id))
            throw new ArgumentException("Id cannot be null or empty", nameof(id));

        if(string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Title cannot be null or empty", nameof(title));

        if(string.IsNullOrWhiteSpace(author))
            throw new ArgumentException("Author cannot be null or empty", nameof(author));

        Id = id.Trim();
        Title = title.Trim();
        Author = author.Trim();
    }

    public override string ToString()
    {
        return $"Id: {Id}, Title: {Title}, Author: {Author}";
    }
}