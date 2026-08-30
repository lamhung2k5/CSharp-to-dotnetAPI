    public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=====================EntityRepository<Student>========================");
        EntityRepository<Student> studentRepo = new EntityRepository<Student>();

        //Thêm ít nhất hai sinh viên.
        Student s1 = new Student("SV01", "Hung");
        Student s2 = new Student("SV02", "Lam");

        studentRepo.Add(s1);
        studentRepo.Add(s2);

        //Hiển thị tất cả.
        Console.WriteLine("----Display all students----");
        studentRepo.DisplayAll();

        //Tìm theo Id.
        Console.WriteLine("----find student----");
        string studentId = "SV02";
        Student? foundStudent = studentRepo.FindById(studentId);

        if(foundStudent != null)
        {
            Console.WriteLine($"Found student with id {studentId}");
            foundStudent.DisplayInfo();
        }
        else
        {
            Console.WriteLine($"Cannot find student with id {studentId}");
        }

        //Kiểm tra số lượng.
        Console.WriteLine("----test quantity----");
        Console.WriteLine($"quantity: {studentRepo.GetCount()}");


        Console.WriteLine("=====================EntityRepository<Product>========================");
        EntityRepository<Product> productRepo = new EntityRepository<Product>();
        //Thêm ít nhất hai sản phẩm.
        Product p1 = new Product("SP01","laptop samsung");
        Product p2 = new Product("SP02","nokia phone");
        productRepo.Add(p1);
        productRepo.Add(p2);

        //Hiển thị tất cả.
        Console.WriteLine("----Display all products----");
        productRepo.DisplayAll();

        //Tìm theo Id.
        Console.WriteLine("----find product----");
        string productId = "SP02";
        Product? foundProduct = productRepo.FindById(productId);

        if (foundProduct != null)
        {
            Console.WriteLine($"Product with id {productId} is already exists.");
        }
        else
        {
            Console.WriteLine($"Cannot find product with id {productId}");
        }

        //Kiểm tra ContainsId().
        Console.WriteLine("----Contains product----");

        string containsProductId = "SP03";

        if (productRepo.ContainsId(containsProductId)) 
        {
            Console.WriteLine($"Product with id {containsProductId} exists.");
        }
        else
        {
            Console.WriteLine($"Cannot find Product with id {containsProductId} does not exist.");
        }

        //Xóa một sản phẩm.
        Console.WriteLine("----Remove product----");
        if(productRepo.RemoveById("SP01"))
        {
            Console.WriteLine("Remove successfully");
        }
        else
        {
            Console.WriteLine("Remove fail.");
        }
        //Hiển thị lại.
        productRepo.DisplayAll();

        Console.WriteLine("===================testing another case======================");
        //thêm null (hien duoc loi)
        try
        {
            //productRepo.Add(null);
            studentRepo.Add(null);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"Argument null Error: {ex.Message}");
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        //thêm entity trùng Id (hien duoc loi)
        try
        {
            Student s3 = new Student("SV01", "Duy");
            studentRepo.Add(s3);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Invalid Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        

        //tìm với id rỗng;

        
        try
        {
            studentRepo.FindById(" ");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Argument Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        //xử lý bằng try-catch riêng cho từng trường hợp.
    }
}