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
            new Product("P05", "USB", 150)
        };

        //Lấy tất cả Product có Price >= 1000.
        var allProducts = products.Where(product => product.Price >= 1000).ToList(); 
        foreach(var product in allProducts)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine(products.Count);
        Console.WriteLine("------------------------------------");

        //Lấy Product có Price< 500.
        var product1 = products.Where(product => product.Price < 500).ToList();
        foreach (var product in product1)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine(products.Count);
        Console.WriteLine("------------------------------------");
        //Lấy Product có Price từ 300 đến 3000.
        var product2 = products.Where(product => product.Price >= 300 && product.Price <= 3000).ToList();
        foreach (var product in product2)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine(products.Count);
        Console.WriteLine("------------------------------------");

        //Lấy Product có Name chứa chữ "o".
        var product3 = products.Where(product => product.Name.Contains("o")).ToList();
        foreach (var product in product3)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine(products.Count);
        Console.WriteLine("------------------------------------");

        //Mỗi kết quả phải được chuyển thành List<Product> bằng ToList().
        //Dùng foreach để hiển thị từng danh sách.
        //Sau khi lọc xong, in lại products.Count để kiểm tra List ban đầu không bị thay đổi.
    }
}