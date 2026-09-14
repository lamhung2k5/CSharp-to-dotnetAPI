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

        // Đếm tổng số Product.
        int productCount = products.Count();
        Console.WriteLine($"quantity: {productCount}");

        // Đếm số Product có Price >= 1000.
        int productCount2 = products.Count(product => product.Price >= 1000);
        Console.WriteLine($"quantity: {productCount2}");

        // Tính tổng Price của tất cả Product.
        decimal productCount3 = products.Sum(product => product.Price);
        Console.WriteLine($"quantity: {productCount3}");

        // Tính tổng Price của Product có Price < 1000.
        decimal productCount4 = products.Where(product => product.Price < 1000).Sum(product => product.Price);
        Console.WriteLine($"quantity: {productCount4}");

        // Tính Price trung bình.
        decimal productPriceAvg = products.Average(product => product.Price);
        Console.WriteLine($"quantity: {productPriceAvg}");

        // Tính Price trung bình của Product có Price >= 1000.
        decimal productPriceAvg2 = products.Where(product => product.Price >= 1000).Average(product => product.Price);
        Console.WriteLine($"quantity: {productPriceAvg2}");          

        // Tìm Price nhỏ nhất.
        decimal minPrice = products.Min(product => product.Price);
        Console.WriteLine($"min: {minPrice}");

        // Tìm Price lớn nhất.
        decimal maxPrice = products.Max(product => product.Price);
        Console.WriteLine($"max: {maxPrice}");

        // Từ minPrice, tìm Product có giá nhỏ nhất bằng FirstOrDefault().
        Product? foundProductWithMinPrice = products.FirstOrDefault(product => product.Price == minPrice);
        Console.WriteLine($"Product with min Price: {foundProductWithMinPrice}");

        // Từ maxPrice, tìm Product có giá lớn nhất bằng FirstOrDefault().
        Product? foundProductWithMaxPrice = products.FirstOrDefault(product => product.Price == maxPrice);
        Console.WriteLine($"Product with max Price: {foundProductWithMaxPrice}");

        // Tạo collection rỗng và kiểm tra:
        List<Product> emptyProduct = new List<Product>();

        // Count()
        int emptyProductCount = emptyProduct.Count();
        Console.WriteLine(emptyProductCount);

        // Sum()
        decimal emptyProductSum = emptyProduct.Sum(product => product.Price);
        Console.WriteLine(emptyProductSum);

        // Average() hiện lỗi Sequence contains no elements
        try
        {
            decimal emptyProductAvg = emptyProduct.Average(product => product.Price);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        // Với Average(), dùng try/catch để quan sát exception.
    }
}