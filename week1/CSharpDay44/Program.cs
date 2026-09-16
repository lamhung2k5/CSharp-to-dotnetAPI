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
            new Product("P08", "Mouse", 1200)
        };

        // Dùng Select() + Distinct() lấy các mức Price không trùng.
        var distinctProductPrice = products.Select(Product => Product.Price).Distinct();
        foreach(decimal product in distinctProductPrice)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("---------------------------------");

        // Lấy các Name không trùng.
        var distinctProductName = products.Select(product => product.Name).Distinct();
        foreach(string product in distinctProductName)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("---------------------------------");
        
        // Lấy các Price không trùng rồi sắp tăng dần.
        var distinctProductOrderBy = products.Select(product => product.Price).Distinct().OrderBy(price => price);
        foreach(decimal product in distinctProductOrderBy)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("---------------------------------");
        
        // Lọc Product có Price >= 300, sau đó lấy các mức Price không trùng.
        var distinctProductPrice2 = products.Where(product => product.Price >= 300).Select(product => product.Price).Distinct();
        foreach(decimal product in distinctProductPrice2)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("---------------------------------");

        // Chuyển kết quả câu 1 thành List<decimal>.
        List<decimal> distinctProductList = distinctProductPrice.ToList();
        foreach(decimal product in distinctProductList)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("---------------------------------");

        // Dùng foreach hiển thị kết quả.
        // Kiểm tra products gốc không bị thay đổi. (cac product khong bij thay doi)
    }
}