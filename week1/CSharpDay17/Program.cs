public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            ProductCatalog catalog = new ProductCatalog("Electronics");

            catalog.AddProduct(
                new Product(
                    "P01",
                    "Laptop",
                    20_000_000m));

            catalog.AddProduct(
                new Product(
                    "P02",
                    "Mouse",
                    500_000m));

            catalog.AddProduct(
                new Product(
                    "P03",
                    "Keyboard",
                    1_200_000m));

            catalog.DisplayProducts();

            Product? found =
                catalog.FindProductById("P02");

            if (found != null)
            {
                Console.WriteLine(
                    $"Tim thay: {found}");
            }

            bool removed =
                catalog.RemoveProductById("P01");

            Console.WriteLine(
                removed
                    ? "Xoa thanh cong"
                    : "Khong tim thay");

            catalog.DisplayProducts();

        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}