public class Program
{
    public static void Main(string[] args)
    {
        var bookService = new BookService();
        var bookManager = new BookManager(bookService);
        bookManager.DisplayBooks();
    }
}