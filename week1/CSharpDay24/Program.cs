public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            //=================GenericStorage<int>======================
            Console.WriteLine("====GenericStorage<int>====");
            GenericStorage<int> nums = new GenericStorage<int>("Numbers: ");

            //Thêm ít nhất ba số.
            nums.AddItem(4);
            nums.AddItem(5);
            nums.AddItem(7);

            //Lấy phần tử đầu.
            Console.WriteLine($"First item: {nums.GetFirstItem()}");

            //Lấy phần tử cuối.
            Console.WriteLine($"Last item: {nums.GetLastItem()}");

            //Kiểm tra một số có tồn tại.
            int num = 8;
            Console.WriteLine(nums.ContainsItem(num) ? $"{num} is already exists." : $"{num} is not already exists.");

            //Xóa một số.
            nums.RemoveItem(7);

            //Hiển thị toàn bộ.
            Console.WriteLine("After remove: ");
            nums.DisplayItems();

            //==================GenericStorage<string>=============================
            Console.WriteLine("====GenericStorage<string>====");
            GenericStorage<string> strs = new GenericStorage<string>("Strings: ");
            //Thêm ba tên.
            strs.AddItem("huong");
            strs.AddItem("chi");
            strs.AddItem("nhu");

            //Lấy một phần tử theo index.
            Console.WriteLine($"index: {2}, value: {strs.GetItemAt(2)}");

            //Xóa một tên.
            strs.RemoveItem("chi");

            //Hiển thị danh sách.
            Console.WriteLine("After remove: ");
            strs.DisplayItems();


            //==================GenericStorage<Product>=====================
            Console.WriteLine("====GenericStorage<Product>====");
            GenericStorage<Product> products = new GenericStorage<Product>("Products: ");

            //Tạo ít nhất hai sản phẩm.
            Product p1 = new Product("SP01", "sua rua mat");
            Product p2 = new Product("SP02", "thuoc tri mun");
            //Thêm vào storage.
            products.AddItem(p1);
            products.AddItem(p2);

            //Hiển thị.
            products.DisplayItems();

            //Lấy sản phẩm đầu tiên.
            Console.WriteLine($"First product: {products.GetFirstItem()}");

            //Kiểm tra GetItemCount().
            Console.WriteLine($"count: {products.GetItemCount()}");

            //=========================Testing========================
            //Lấy phần tử từ storage rỗng.
            GenericStorage<int> numlist = new GenericStorage<int>("empty list");
            numlist.GetFirstItem();

            //Truy cập index không hợp lệ.
            Product p3 = products.GetItemAt(-1);

            //Xử lý bằng try-catch.
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine($"Argument error: {ex.Message}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Invalid operation error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Another error: {ex.Message}");
        }
    }
}