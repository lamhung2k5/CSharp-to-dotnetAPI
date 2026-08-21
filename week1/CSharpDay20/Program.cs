public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            StudentCourseRegistration registration = new StudentCourseRegistration("SV01");

            // 1. Đăng ký các môn học ban đầu
            Console.WriteLine("=== REGISTER COURSES ===");

            bool addedCSharp = registration.RegisterCourse("C#");

            bool addedSql = registration.RegisterCourse("SQL");

            bool addedDotNet = registration.RegisterCourse(".NET");

            Console.WriteLine(addedCSharp ? "C# registered successfully." : "C# is already registered.");

            Console.WriteLine(addedSql ? "SQL registered successfully." : "SQL is already registered.");

            Console.WriteLine(addedDotNet ? ".NET registered successfully." : ".NET is already registered.");

            // 2. Hiển thị danh sách môn học
            Console.WriteLine("\n=== REGISTERED COURSES ===");
            registration.DisplayRegisteredCourses();

            // 3. Thử đăng ký môn đã tồn tại
            Console.WriteLine("\n=== TEST DUPLICATE COURSE ===");

            bool addedDuplicate = registration.RegisterCourse("C#");

            Console.WriteLine( addedDuplicate ? "C# registered successfully." : "C# is already registered.");

            // 4. Kiểm tra không phân biệt hoa thường
            Console.WriteLine("\n=== TEST CASE INSENSITIVE ===");

            bool addedOop =  registration.RegisterCourse("OOP");

            bool addedLowercaseOop = registration.RegisterCourse("oop");

            Console.WriteLine($"Register OOP: {addedOop}");

            Console.WriteLine( $"Register oop: {addedLowercaseOop}");

            // Kết quả mong đợi:
            // Register OOP: True
            // Register oop: False

            // 5. Kiểm tra môn học đã đăng ký
            Console.WriteLine("\n=== CHECK COURSE ===");

            bool hasSql = registration.IsCourseRegistered("sql");

            Console.WriteLine(hasSql ? "SQL is registered." : "SQL is not registered.");

            bool hasDsa = registration.IsCourseRegistered("DSA");

            Console.WriteLine(hasDsa ? "DSA is registered." : "DSA is not registered.");

            // 6. Hủy môn học đang tồn tại
            Console.WriteLine("\n=== UNREGISTER COURSE ===");

            bool removedCSharp = registration.UnregisterCourse("C#");

            Console.WriteLine(removedCSharp ? "C# removed successfully." : "C# was not found.");

            // 7. Thử hủy môn không tồn tại
            bool removedDsa = registration.UnregisterCourse("DSA");

            Console.WriteLine(removedDsa ? "DSA removed successfully." : "DSA was not found.");

            // 8. Hiển thị lại danh sách
            Console.WriteLine("\n=== COURSES AFTER REMOVING ===");
            registration.DisplayRegisteredCourses();

            // 9. Thử dữ liệu không hợp lệ
            Console.WriteLine("\n=== TEST INVALID DATA ===");

            registration.RegisterCourse("   ");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(
                $"Invalid argument: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(
                $"Unexpected error: {ex.Message}");
        }
    }
}