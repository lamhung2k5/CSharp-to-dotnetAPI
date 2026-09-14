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

        // Kiểm tra collection có Product nào không bằng Any().
        bool hasProducts = products.Any();

        if (hasProducts)
        {
            Console.WriteLine("Products list has at least one element.");
        }
        else
        {
            Console.WriteLine("Products list is empty.");
        }

        // Kiểm tra có Product nào có Price >= 10000 không.
        bool foundProduct2 = products.Any(product => product.Price >= 10000);
        if(foundProduct2)
        {
            Console.WriteLine("Found product successfully");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }

        // Kiểm tra có Product có Id == "P03" không.
        bool foundProduct3 = products.Any(product => product.Id == "P03");
        if(foundProduct3)
        {
            Console.WriteLine("Found product successfully");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }   

        // Kiểm tra có Product có Id == "P99" không.
        bool foundProduct4 = products.Any(product => product.Id == "P99");
        if(foundProduct4)
        {
            Console.WriteLine("Found product successfully");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }

        // Kiểm tra tất cả Product có Price > 0 không.
        bool foundProduct5 = products.All(product => product.Price > 0);
        if(foundProduct5)
        {
            Console.WriteLine("Found product successfully");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }

        // Kiểm tra tất cả Product có Price >= 500 không.
        bool foundProduct6 = products.All(product => product.Price >= 500);
        if(foundProduct6)
        {
            Console.WriteLine("Found product successfully");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }

        //dùng Any() để kiểm tra ID đã tồn tại
        string newProductId = "P01";
        if(products.Any(product => product.Id == newProductId))
        {
            Console.WriteLine("Product ID already exists.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }

        //tao list rong va kiem tra 
        List<Product> emptyProducts = new List<Product>();
        
        //do any tra ve true 
        if(!emptyProducts.Any())
        {
            Console.WriteLine("This Products List is empty.");
        }
        else

        {
            Console.WriteLine("This Products List have at least element.");
        }

        //all tra ve false
        if(!emptyProducts.All(product => product.Id == "P01"))
        {
            Console.WriteLine("This Products List is empty.");
        }
        else
        {
            Console.WriteLine("This Products List have at least element.");
        }
    }
}