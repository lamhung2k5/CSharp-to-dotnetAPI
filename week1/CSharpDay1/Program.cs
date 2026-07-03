//1. Tạo project Console App tên CSharpDay01.
//2. In ra họ tên, lớp, email và mục tiêu học .NET của bạn.
Console.WriteLine("name: Lam Hung");
Console.WriteLine("class: DA23TTA");
Console.WriteLine("Purpose of learning C#: to learn .NET");
//3. Yêu cầu người dùng nhập tên, sau đó in lời chào.
//4. Chạy project bằng dotnet run.
//5. Build project bằng dotnet build và ghi lại nếu có lỗi.

/*Tạo project StudentIntroApp. Chương trình yêu cầu người dùng nhập: họ tên, email, công nghệ đang học, 
công nghệ muốn học sau C#. Sau đó in ra một hồ sơ học tập ngắn.
===== HỒ SƠ HỌC TẬP =====
Họ tển: Lẩm Tẩn Hưng
Email: example@gmail.com
Đang học: C# nển tang
Mục tiểu tiểp theo: ASP.NET Core Web API
=========================*/
Console.WriteLine("name: ");
string? name = Console.ReadLine();
Console.WriteLine("email: ");
string? email = Console.ReadLine();
Console.WriteLine("Tech you are learning: ");
string? tech_now = Console.ReadLine();
Console.WriteLine("Tech you want to learn after C# course: ");
string? tech_future = Console.ReadLine();

Console.WriteLine("===== HỒ SƠ HỌC TẬP =====");
Console.WriteLine($"name: {name}");
Console.WriteLine($"email: {email}");
Console.WriteLine($"tech_now: {tech_now}");
Console.WriteLine($"tech_future: {tech_future}");
Console.WriteLine("=========================");