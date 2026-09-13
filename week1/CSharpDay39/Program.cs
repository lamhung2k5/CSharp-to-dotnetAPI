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

        //Dùng First() lấy Product đầu tiên.
        Product? product1 = products.First();
        Console.WriteLine(product1);
        Console.WriteLine("----------------------------");

        //Dùng First() lấy Product đầu tiên có Price >= 1000.
        Product? product2 = products.First(product => product.Price >= 1000);
        Console.WriteLine(product2);
        Console.WriteLine("----------------------------");

        //Dùng FirstOrDefault() tìm Product có Id == "P99" và kiểm tra null.
        Product? product3 = products.FirstOrDefault(product => product.Id == "P99");
        if(product3 == null)
        {
            Console.WriteLine("Product not found");
        }
        else
        {
            Console.WriteLine(product3);
        }
        Console.WriteLine("----------------------------");

        //Dùng Single() tìm Product có Id == "P02".
        Product? product4 = products.Single(product => product.Id == "P02");
        Console.WriteLine(product4);
        Console.WriteLine("----------------------------");

        //Dùng SingleOrDefault() tìm Product có Id == "P99".
        Product? product5 = products.SingleOrDefault(product => product.Id == "P99");
        if(product5 == null)
        {
            Console.WriteLine("Product not found");
        }
        else
        {
            Console.WriteLine(product5);
        }
        Console.WriteLine("----------------------------");

        //Test Single() với điều kiện:
        //        product => product.Price >= 1000
        try
        {
            Product? product6 = products.Single(product => product.Price >= 1000);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine("--------------------------");
        //và dùng try/catch để quan sát chuyện gì xảy ra. (hien loi: Sequence contains more than one matching element)

        //7.Dùng:
        //Where + Select + FirstOrDefault
        //để lấy Name đầu tiên của Product có Price >= 1000.
        string? product7 = products.Where(product => product.Price >= 1000).Select(product => product.Name).FirstOrDefault();
        if (product7 == null)
        {
            Console.WriteLine("Product not found");
        }
        else
        {
            Console.WriteLine(product7);
        }
        Console.WriteLine("----------------------------");
        //ket qua: Monitor


        //8.Hiển thị các kết quả phù hợp mà không dùng foreach cho những truy vấn trả về một phần tử.
        
    }
}