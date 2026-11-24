public class BookManager
{
    private readonly IBookService _service;

    public BookManager(IBookService service)
    {
        _service = service;
    }

    public void DisplayBooks()
    {
        var books = _service.GetBooks();
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }
}