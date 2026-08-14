public class Library
{
    public string Name { get; private set; }
    private List<Book> Books;

    public Library(string name, List<Book> books)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be null or empty.", nameof(name));
        }
        if(books == null) 
        {
            throw new ArgumentNullException(nameof(books), "Books list cannot be null.");
        }
        Name = name.Trim();
        Books = books;
    }
    public void AddBook(Book book)
    {
        if (book == null)
        {
            throw new ArgumentNullException(nameof(book), "Book cannot be null.");
        }
        Books.Add(book);
    }
    public void DisplayBooks()
    {
        foreach (var book in Books)
        {
            book.DisplayInfo();
        }
    }
}