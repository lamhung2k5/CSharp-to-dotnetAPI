public class Program
{
    public static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Product("Mouse", 20),
            new Product("Keyboard", 80),
            new Product("Monitor", 300),
            new Product("Laptop", 1500)
        };


        Console.WriteLine("=== Predicate Variable ===");

        Predicate<Product> condition = ProductCondition.IsExpensive;

        Console.WriteLine($"Laptop is expensive?: {condition(products[3])}");


        Console.WriteLine("\n=== Find ===");

        Product? expensiveProduct = products.Find(ProductCondition.IsExpensive);

        if (expensiveProduct != null)
        {
            Console.WriteLine($"First expensive product: {expensiveProduct}");
        }
        else
        {
            Console.WriteLine("No expensive product found.");
        }


        Console.WriteLine("\n=== FindAll ===");

        List<Product> cheapProducts = products.FindAll(ProductCondition.IsCheap);

        foreach (Product product in cheapProducts)
        {
            Console.WriteLine(product);
        }


        Console.WriteLine("\n=== Exists ===");

        bool hasExpensiveProduct = products.Exists(ProductCondition.IsExpensive);

        Console.WriteLine($"Has expensive product?: {hasExpensiveProduct}");


        Console.WriteLine("\n=== Change Predicate ===");

        condition = ProductCondition.IsCheap;

        Console.WriteLine($"Mouse is cheap?: {condition(products[0])}");
    }
}