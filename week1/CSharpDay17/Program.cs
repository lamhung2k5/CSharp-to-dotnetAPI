using System.Net.Http.Headers;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            ProductCatalog catalog = new ProductCatalog("Electronics");

            catalog.AddProduct(new Product("P01","Laptop",20_000_000m));
            catalog.AddProduct(new Product("P02","Mouse",500_000m));
            catalog.AddProduct(new Product("P03","Keyboard",1_200_000m));

            //hien thi cac san pham trong danh muc
            catalog.DisplayProducts();

            //tim san phan có id = "P02", neu tim thay thi hien thi thong tin san pham do, neu khong tim thay hien thi thong bao phu hop
            Product? foundProduct = catalog.FindProductById("P05");
            if(foundProduct == null)
            {
                Console.WriteLine("Product not found");
            }
            else
            {
                foundProduct.DisplayInfo();
            }

            //xoa san pham id = "P01", neu xoa thanh cong hien thi thong bao thanh cong, neu khong tim thay san pham thi hien khong tim thay san pham
            if(catalog.RemoveProductById("P01"))
            {
                Console.WriteLine("Product removed successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }

            //hien thi toan bo danh sach sau khi xoa
            catalog.DisplayProducts();

            //kiem tra id khong hop le
            try
            {
                catalog.FindProductById("  ");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            //id trung voi san pham hien tai
            try
            {
                catalog.AddProduct(new Product("P02", "Monitor", 3_000_000m));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}