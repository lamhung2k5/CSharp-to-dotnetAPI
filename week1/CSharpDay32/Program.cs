public class Program
{
    public static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
        new Product("Mouse", 20),
        new Product("Keyboard", 80),
        new Product("Monitor", 300),
        new Product("Laptop", 1500)
        };

        //kiem tra so lon hon 0
        Predicate<int> testNum = number => number > 0;
        Console.WriteLine(testNum(5));
        Console.WriteLine(testNum(-5));

        //tinh binh phuong
        Func<int, int> square = number => number * number;
        Console.WriteLine(square(5));

        //cong hai so
        Func<int, int, int> Add = (a, b) => a + b;
        Console.WriteLine(Add(5, 10));

        //in string
        Action<string> Message = message => Console.WriteLine($"Message: {message}");
        Message("Hello World!");

        //tim product co gia lon hon 1000
        Console.WriteLine(products.Find(product => product.Price > 1000));

        //tim tat ca product co gia nho hon 100
        List<Product> cheapProducts = products.FindAll(product => product.Price < 100);
        Console.WriteLine("Cheap products:");
        foreach (Product product in cheapProducts)
        {
            Console.WriteLine($" - {product.Name}: ${product.Price}");
        }

        //kiem tra xem cos product nao co gia >=1000 khong
        if (products.Exists(product => product.Price >= 1000))
        {
            Console.WriteLine("There is at least one product with a price of $1000 or more.");
        }
        else
        {
            Console.WriteLine("No products found with a price of $1000 or more.");
        }

        //viet mot statement lambda cos it nhat hai cau lenh trong than
        Action<string> printMessage = message =>
        {
            Console.WriteLine("Printing message:");
            Console.WriteLine(message);
        };
        printMessage("Hello, Lambda!");
    }
}