public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Book b1 = new Book("B01", "C# Programming", "John Doe");
            Book b2 = new Book("B02", "Java Programming", "Jane Smith");

            List<Book> books = new List<Book> { b1, b2 };
            Library library = new Library("City Library", books);

            library.DisplayBooks();
        }
        catch(Exception ex) 
        { 
            Console.WriteLine($"An error occurred: {ex.Message}"); 
        }
    }
}