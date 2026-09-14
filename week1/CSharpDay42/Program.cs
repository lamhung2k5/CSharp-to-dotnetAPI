public class Program
{
    public static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Product("P01", "Mouse", 300),
            new Product("P02", "Keyboard", 700),
            new Product("P03", "Monitor", 2500),
            new Product("P04", "Laptop", 15000),
            new Product("P05", "USB", 150),
            new Product("P06", "Cable", 300),
            new Product("P07", "Adapter", 700)
        };

        //Sắp xếp Product theo Price tăng dần.
        var productsAscending = products.OrderBy(product => product.Price);
        foreach(Product product in productsAscending)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("----------------------------------------");
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("========================================");
        //Sắp xếp Product theo Price giảm dần.
        var productsDescending = products.OrderByDescending(product => product.Price);
        foreach (Product product in productsDescending)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("----------------------------------------");
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("========================================");

        //Sắp xếp Product theo Name tăng dần.
        var productsNameAscending = products.OrderBy(product => product.Name);
        foreach (Product product in productsNameAscending)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("----------------------------------------");
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("========================================");

        //Sắp xếp Product theo Name giảm dần.
        var productsNameDescending = products.OrderByDescending(product => product.Name);
        foreach (Product product in productsNameDescending)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("----------------------------------------");
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("========================================");
        //Sắp theo Price tăng dần; nếu cùng Price thì Name tăng dần.
        var products1 = products.OrderBy(product => product.Price).ThenBy(product => product.Name);
        foreach (Product product in products1)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("----------------------------------------");
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("========================================");

        //Sắp theo Price tăng dần; nếu cùng Price thì Name giảm dần.
        var products2 = products.OrderBy(product => product.Price).ThenByDescending(product => product.Name);
        foreach (Product product in products2)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("----------------------------------------");
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("========================================");

        //Lọc các Product có Price >= 300, sau đó sắp Price giảm dần.
        var products3 = products.Where(product => product.Price >= 300).OrderByDescending(product => product.Price);
        foreach (Product product in products3)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("----------------------------------------");
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("========================================");

        //Sắp Product theo Price tăng dần, sau đó dùng Select() chỉ lấy Name thành List<string>.
        var products4 = products.OrderBy(product => product.Price).Select(product => product.Name).ToList();
        foreach (string product in products4)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("----------------------------------------");
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("========================================");

        //Dùng foreach hiển thị kết quả của từng truy vấn.
        //Kiểm tra danh sách products ban đầu sau các truy vấn để xác nhận nó không bị thay đổi.
    }
}