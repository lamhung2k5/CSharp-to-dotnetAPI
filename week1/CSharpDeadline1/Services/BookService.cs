public class BookService : IBookService
{
    public List<Book> GetBooks()
    {
        return new List<Book>
        {
            new Book("1", "The Great Gatsby", "F. Scott Fitzgerald"),
            new Book("2", "To Kill a Mockingbird", "Harper Lee"),
            new Book("3", "1984", "George Orwell")
        };
    }
}