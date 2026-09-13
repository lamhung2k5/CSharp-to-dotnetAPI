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

        //Dùng Select() lấy tất cả Name thành List<string>.
        List<string> productsName = products.Select(product => product.Name).ToList();
        foreach(string product in productsName)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("-------------------------------------");


        //Dùng Select() lấy tất cả Price thành List<decimal>.
        List<decimal> productsPrice = products.Select(product => product.Price).ToList();
        foreach (decimal price in productsPrice)
        {
            Console.WriteLine(price);
        }
        Console.WriteLine("-------------------------------------");

        //Tạo danh sách chuỗi dạng: P01 - Mouse, P02 - Keyboard...
        List<string> productsString = products.Select(product => $"Id: {product.Id}, Price: {product.Name}").ToList();
        foreach (string product in productsString)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("-------------------------------------");

        //Dùng Where() + Select() để lấy tên những Product có Price >= 1000.
        List<string> productList = products.Where(product => product.Price >= 1000).Select(product => product.Name).ToList();
        foreach (string product in productList)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("-------------------------------------");

        //Dùng Where() +Select() để lấy giá của Product có Price < 1000.
        List<decimal> productList2 = products.Where(product => product.Price < 1000).Select(product => product.Name).ToList();
        foreach (decimal product in productList2)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("-------------------------------------");

        //dùng select để chuyển List<Product> thành List<ProductSummary>
        List<ProductSummary> productSummaryList = products.Select(product => new ProductSummary(product.Name, product.Price)).ToList();
        foreach (ProductSummary product in productSummaryList)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("-------------------------------------");
    }
}