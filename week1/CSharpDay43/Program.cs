using System.Net.Http.Headers;

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
            new Product("P07", "Adapter", 700),
            new Product("P08", "Webcam", 1200),
            new Product("P09", "Speaker", 900),
            new Product("P10", "Headphone", 1100)
        };

        // Dùng Skip(3) và hiển thị kết quả.
        var productsSkip3 = products.Skip(3);
        foreach(Product product in productsSkip3)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("--------------------------------");
        foreach(Product product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("=====================================");
        // Dùng Take(4) và hiển thị kết quả.
        var productsTake4 = products.Take(4);
        foreach(Product product in productsTake4)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("--------------------------------");
        foreach(Product product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("=====================================");
        // Dùng Skip(2).Take(3).
        var product4 = products.Skip(2).Take(3);
        foreach(Product product in product4)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("--------------------------------");
        foreach(Product product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("=====================================");
        // Sắp theo Price tăng dần rồi lấy 3 Product đầu tiên.
        var product5 = products.OrderBy(product => product.Price).Take(3);
        foreach(Product product in product5)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("--------------------------------");
        foreach(Product product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("=====================================");
        // Sắp theo Price giảm dần rồi bỏ 2 Product đầu và lấy 3 Product tiếp theo.
        var product6 = products.OrderByDescending(product => product.Price).Take(3);
        foreach(Product product in product6)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("--------------------------------");
        foreach(Product product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("=====================================");
        // Lọc Price >= 700, sắp Price tăng dần, sau đó Skip(1).Take(3).
        var product7 = products.Where(product => product.Price >= 700).Skip(1).Take(2);
        foreach(Product product in product7)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("--------------------------------");
        foreach(Product product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("=====================================");     
        // Với: int pageNumber = 2; int pageSize = 3; dùng công thức pagination để lấy trang 2.
        int pageNumber = 2;
        int pageSize = 3;
        var product8 = products.Skip((pageNumber - 1) * pageSize).Take(pageSize);
        foreach(Product product in product8)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("--------------------------------");
        foreach(Product product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("=====================================");
        // Đổi pageNumber = 3, giữ pageSize = 3, kiểm tra kết quả.
        pageNumber = 3;
        pageSize = 3;
        var product9 = products.Skip((pageNumber - 1) * pageSize).Take(pageSize);
        foreach(Product product in product9)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("--------------------------------");
        foreach(Product product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("=====================================");
        
        // Sau pagination, dùng Select() chỉ lấy Name thành List<string>.
        List<string> product8ToList = product8.Select(product => product.Name).ToList();
        foreach(string product in product8ToList)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("--------------------------------");
        foreach(Product product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("=====================================");
        List<string> product9ToList = product9.Select(product => product.Name).ToList();
        foreach(string product in product9ToList)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("--------------------------------");
        foreach(Product product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("=====================================");
        // Test: Skip(100), Take(100), Take(0)
        var productSkip100 = products.Skip(100); 
        foreach(Product product in productSkip100)
        {
            Console.WriteLine(product); //khong hien phan tu
        }
        Console.WriteLine("--------------------------------");
        foreach(Product product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("=====================================");
        var productTake100 = products.Take(100); 
        foreach(Product product in productTake100)
        {
            Console.WriteLine(product); //hien cac phan tu trong list
        }
        Console.WriteLine("--------------------------------");
        foreach(Product product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("=====================================");

        var productTake0 = products.Take(0); 
        foreach(Product product in productTake0)
        {
            Console.WriteLine(product); //khong hien phan tu
        }
        Console.WriteLine("--------------------------------");
        foreach(Product product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("=====================================");
        // Kiểm tra collection products gốc vẫn giữ nguyên (tat ca deu khong thay doi)
    }
}