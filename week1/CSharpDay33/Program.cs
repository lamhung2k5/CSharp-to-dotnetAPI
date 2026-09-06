using System.Net.Http.Headers;

public class Program
{
    public static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Product("Mouse", 20),
            new Product("Keyboard", 80),
            new Product("Monitor", 300),
            new Product("Laptop", 1500),
            new Product("Laptop Stand", 60)
        };


        //1.Find: tìm Product đầu tiên có Price >= 1000.
        Product? foundProduct1 = products.Find(product => product.Price >= 1000);
        Console.WriteLine(foundProduct1);

        //2.Find: tìm Product có Name == "Monitor".
        Product? foundProduct2 = products.Find(product => product.Name == "Monitor");
        Console.WriteLine(foundProduct2);

        //3.FindAll: tìm tất cả Product có Price< 100.
        List<Product> foundProduct3 = products.FindAll(product => product.Price < 100);
        foreach (Product product in foundProduct3)
        {
            Console.WriteLine(product);
        }

        //4.FindAll: tìm tất cả Product có Name chứa "Laptop".
        List<Product> foundProduct4 = products.FindAll(product => product.Name.Contains("Laptop"));
        foreach (Product product in foundProduct4)
        {
            Console.WriteLine(product);
        }

        //5.Exists: kiểm tra có Product nào Price > 2000 không.
        if (products.Exists(product => product.Price > 2000))
        {
            Console.WriteLine($"There are at least one product with a price of 2000$ or more.");
        }
        else
        {
            Console.WriteLine("No products found with a price of $2000 or more.");
        }

        //6.Exists: kiểm tra có Product tên "Mouse" không.
        if (products.Exists(product => product.Name == "Mouse"))
        {
            Console.WriteLine($"There are at least one product with name is mouse");
        }
        else
        {
            Console.WriteLine("No products found with name is mouse");
        }


        //7.FindAll: Price >= 50 và Price <= 300.
        List<Product> productsList = products.FindAll(product => product.Price >= 50 && product.Price <= 300);
        foreach(Product product in productsList)
        {
            Console.WriteLine(product);
        }

        //8.RemoveAll: xóa các Product có Price < 50 và in số lượng đã xóa.
        List<Product> products1 = new List<Product>
        {
            new Product("Mouse", 20),
            new Product("Keyboard", 80),
            new Product("Monitor", 300),
            new Product("Laptop", 1500),
            new Product("Laptop Stand", 60)
        };
        int productCount = products1.RemoveAll(product => product.Price < 50);
        Console.WriteLine(productCount);
    }
}