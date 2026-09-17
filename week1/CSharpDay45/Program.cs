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
            new Product("P08", "Mouse", 1200),
            new Product("P09", "USB", 200)
        };

        //Group Product theo Price.
        var productGroupByPrice = products.GroupBy(product => product.Price);

        //Dùng foreach lồng nhau để hiển thị:
        foreach (var group in productGroupByPrice)
        {
            //group.Key;
            Console.WriteLine(group.Key);

            //các Product trong group.
            foreach (Product item in group)
            {
                Console.WriteLine($" - {item}");
            }
        }
        Console.WriteLine("----------------------------------------");

        //Với mỗi nhóm Price, hiển thị số lượng Product bằng Count().
        foreach(var group in productGroupByPrice)
        {
            Console.WriteLine(group.Key);
            Console.WriteLine($"quantity: {group.Count()}");
        }
        Console.WriteLine("----------------------------------------");


        //Group Product theo Name.
        var productGroupByName = products.GroupBy(product => product.Name);

        //Với mỗi nhóm Name:
        //hiển thị Name;
        //        số lượng Product;
        //        tổng Price của nhóm.
        foreach(var group in productGroupByName)
        {
            Console.WriteLine(group.Key);
            Console.WriteLine(group.Count());
            Console.WriteLine($" sum: {group.Sum(item => item.Price)}");
        }

        //Group theo Price và sắp các group theo group.Key tăng dần.
        var productGroupByPriceOrderByKey = products.GroupBy(product => product.Price).OrderBy(group => group.Key);  
        foreach(var item in productGroupByPriceOrderByKey)
        {
            Console.WriteLine(item.Key);
        }

        //Group theo Name và chỉ lấy những group có từ 2 Product trở lên.
        var productGroupByName2 = products.GroupBy(product => product.Name).Where(group => group.Count() >= 2);
        foreach (var item in productGroupByName2)
        {
            Console.WriteLine(item.Key);
        }

        //Kiểm tra products gốc không bị thay đổi.
        //Tạo collection rỗng rồi thử GroupBy().
        List<Product> emptyProducts = new List<Product>();

        var emptyProductGroupBy = emptyProducts.GroupBy(product => product.Name);
        //Quan sát kiểu dữ liệu bằng var, nhưng tự giải thích kiểu theo từng bước.
    }
}