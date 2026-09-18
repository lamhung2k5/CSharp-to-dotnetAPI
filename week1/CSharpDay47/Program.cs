public class Program
{
    public static void Main(string[] args)
    {
        List<Category> categories = new List<Category>
        {
            new Category("C01", "Accessories"),
            new Category("C02", "Computer"),
            new Category("C03", "Storage")
        };

        List<Product> products = new List<Product>
        {
            new Product("P01", "Mouse", "C01", 300, 10),
            new Product("P02", "Keyboard", "C01", 700, 5),
            new Product("P03", "Monitor", "C02", 2500, 3),
            new Product("P04", "Laptop", "C02", 15000, 2),
            new Product("P05", "USB", "C03", 150, 20),
            new Product("P06", "Cable", "C01", 300, 0),
            new Product("P07", "SSD", "C03", 1800, 4),
            new Product("P08", "Webcam", "C01", 1200, 6),
            new Product("P09", "HDD", "C03", 1200, 7),
            new Product("P10", "Laptop Stand", "C01", 700, 8)
        };

        
        //Lấy tất cả Product có Price >= 700 và Stock > 0, sau đó hiển thị kết quả.
        var stockProducts = products.Where(product => product.Price >= 700 && product.Stock > 0).ToList();
        foreach(var product in stockProducts)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("---------------------------------------");

        //Từ các Product còn hàng, chỉ lấy Name thành một collection mới.
        var stockProductsName = products.Where(product => product.Stock > 0).Select(product => product.Name).ToList();
        foreach (var product in stockProductsName)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("---------------------------------------");

        //Tìm Product có Id = "P04".Nếu không tồn tại thì in thông báo phù hợp.
        var foundProduct = products.FirstOrDefault(product => product.Id == "P04");
        if(foundProduct != null)
        {
            Console.WriteLine(foundProduct);
        }
        else
        {
            Console.WriteLine($"Product does not exist.");
        }
        Console.WriteLine("---------------------------------------");
        //Kiểm tra:
        //        có Product nào Stock == 0 hay không;
        bool testStockProduct = products.Any(product => product.Stock == 0);
        if (testStockProduct)
        {
            Console.WriteLine($"Found product with stock = 0");
        }
        else
        {
            Console.WriteLine($"Product does not exist.");
        }
        //        tất cả Product có Price > 0 hay không.
        bool testAllProductPrice = products.All(product => product.Price > 0);
        if (testAllProductPrice)
        {
            Console.WriteLine($"All Product have Price greater than 0");
        }
        else
        {
            Console.WriteLine($"There are at least one product have price = 0");
        }
        Console.WriteLine("---------------------------------------");

        //Thống kê:
        //        tổng số Product;
        var productsQuantity = products.Count();
        Console.WriteLine($"quantity: {productsQuantity}");
        //        số Product còn hàng;
        var productsStockQuantity = products.Count(product => product.Stock > 0);
        Console.WriteLine($"products stock quantity: {productsStockQuantity}");
        //        tổng Stock;
        var productsStockSum = products.Sum(product => product.Stock);
        Console.WriteLine($"Sum of products stock: {productsStockSum}");
        //        giá trung bình;
        var productsStockAvg = products.Average(product => product.Price);
        Console.WriteLine($"Average of products price: {productsStockAvg}");
        //        giá thấp nhất;
        var minProductPrice = products.Min(product => product.Price);
        Console.WriteLine($"min of products price: {minProductPrice}");
        //        giá cao nhất.
        var maxProductPrice = products.Max(product => product.Price);
        Console.WriteLine($"max of products price: {maxProductPrice}");
        Console.WriteLine("---------------------------------------");

        //Sắp Product theo Price giảm dần. Nếu cùng Price thì sắp Name tăng dần.
        var productsOrderByDescPrice = products.OrderByDescending(product => product.Price).ThenBy(product => product.Name);
        foreach (var product in productsOrderByDescPrice)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("---------------------------------------");

        //Phân trang danh sách Product sau khi sắp theo Id:
        //        pageNumber = 2;
        //        pageSize = 3.
        int pageNumber = 2;
        int pageSize = 3;
        var productsPagination = products.OrderBy(product => product.Id).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        foreach (var product in productsPagination)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("---------------------------------------");

        //Lấy danh sách các mức Price không trùng và sắp tăng dần.
        var distinctProductPrice = products.Select(product => product.Price).Distinct().OrderBy(price => price);
        foreach (var product in distinctProductPrice)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("---------------------------------------");

        //Group Product theo CategoryId. Với mỗi group, hiển thị:
        //        CategoryId;
        //        số Product;
        //        tổng Stock;
        //        giá trung bình.
        var productGroupBy = products.GroupBy(product => product.CategoryId);
        foreach(var group in productGroupBy)
        {
            Console.WriteLine(group.Key);
            Console.WriteLine($" - quantity: {group.Count()}");
            Console.WriteLine($" - stock quantity: {group.Sum(product => product.Stock)}");
            Console.WriteLine($" - Price average: {group.Average(product => product.Price)}");
        }
        Console.WriteLine("---------------------------------------");

        //Chỉ giữ những group có ít nhất 3 Product.
        var keepProductGroupBy = productGroupBy.Where(group => group.Count() >= 3);
        foreach (var group in keepProductGroupBy)
        {
            Console.WriteLine(group.Key);

            foreach (Product product in group)
            {
                Console.WriteLine(product);
            }
        }
        Console.WriteLine("---------------------------------------");
        //Join products với categories thông qua:
        //      Product.CategoryId
        //      =
        //      Category.Id
        //Kết quả mỗi phần tử phải chứa:
        //        ProductName
        //        CategoryName
        //        Price
        //        Stock
        //Bạn có thể dùng anonymous object.
        var productJoinCategory = products.Join(categories, product => product.CategoryId, category => category.Id, (product, category) => new { ProductName = product.Name, CategoryName = category.Name, Price = product.Price,Stock = product.Stock});
        foreach (var item in productJoinCategory)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("---------------------------------------");

        //Từ kết quả Join ở câu 11, chỉ lấy các Product còn hàng, sắp Price giảm dần và hiển thị.
        var stockProduct1 = productJoinCategory.Where(product => product.Stock > 0).OrderByDescending(product => product.Price);
        foreach (var item in stockProduct1)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("---------------------------------------");

        //Từ kết quả Join, lấy các CategoryName không trùng.
        var stockProduct2 = productJoinCategory.Select(category => category.CategoryName).Distinct();
        foreach (var item in stockProduct2)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("---------------------------------------");

        //Kiểm tra hai collection gốc products và categories vẫn không thay đổi.
        Console.WriteLine("Original products:");

        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }

        Console.WriteLine("Original categories:");

        foreach (Category category in categories)
        {
            Console.WriteLine(category);
        }
        Console.WriteLine("---------------------------------------");
        //Với pipeline sau do bạn tự viết:
        //Where: chon cac san pham con hang, kieu la IEnumerable<Product>
        //→ OrderBy sap xep theo gia tang dan, kieu la IOrderedEnumerable<Product>
        //→ Skip: bo qua 3 phan tu, kieu IEnumerable<Product>
        //→ Take: lay 2 phan tu tiep theo kieu la IEnumerable<Product>
        //→ Select: lay ten cac san pham do, kieu la IEnumerable<string>
        //→ ToList: chuyen IEnumerable<string> sang List<string>
        //hãy giải thích kiểu dữ liệu qua từng bước.
        var productPipeline = products.Where(product => product.Stock > 0).OrderBy(product => product.Price).Skip(3).Take(2).Select(product => product.Name).ToList();
        foreach (var item in productPipeline)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("---------------------------------------");
    }
}