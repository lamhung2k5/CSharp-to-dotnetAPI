public class PrintedBookService : IBookService
{
    public List<Book> GetBooks()
    {
        return new List<Book>
        {
            new Book("1", "sach ebook1", "F. Scott Fitzgerald"),
            new Book("2", "sach ebook2", "Harper Lee"),
            new Book("3", "sach ebook3", "George Orwell")
        };
    }
}