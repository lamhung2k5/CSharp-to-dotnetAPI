public class Program
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student("S01", "An"),
            new Student("S02", "Binh"),
            new Student("S03", "Cuong"),
            new Student("S04", "Dung")
        };

        List<Registration> registrations = new List<Registration>
        {
            new Registration("S01", "C#"),
            new Registration("S01", "SQL"),
            new Registration("S02", "Java"),
            new Registration("S04", "ASP.NET"),
            new Registration("S05", "Python")
        };

        //Dùng Join() nối Student.Id với Registration.StudentId, tạo kết quả kiểu string theo dạng "StudentName - CourseName". (kieu cuoi cung: IEnumerable<string>)
        var result1 = students.Join(registrations, student => student.Id, registration => registration.StudentId, (student, registration) => $"{student.Name} - {registration.ObjectName}");
        //Dùng foreach hiển thị toàn bộ kết quả.
        foreach (var item in result1)
        {
            Console.WriteLine(item);
        }

        //Quan sát S03 và giải thích vì sao không xuất hiện (vi o registration khong co StudentId S03 nen join khong the noi va khong the hien len duoc).
        //Quan sát Registration "S05" - "Python" và giải thích vì sao không xuất hiện. (vi o student khong co StudentId S05 nen join khong the noi va khong the hien len duoc)
        //Giải thích vì sao S01 xuất hiện hai lần. (vif co hai ma S01 xuat hien ben registration nen khi student join registration theo id thi no xuat hien hai lan)

        //Dùng Join() nhưng result selector chỉ trả về tên sinh viên.
        var result2 = students.Join(registrations, student => student.Id, registration => registration.StudentId, (student, registration) => student.Name);
        foreach (var item in result2)
        {
            Console.WriteLine(item);
        }

        //Với câu 6, xác định kiểu kết quả. Quan sát xem tên "An" xuất hiện bao nhiêu lần và giải thích.(kieu la IEnumerable<sting>, An xuat hien 2 lan, vi student co S01 la an, join voi registration qua id, bene registration co hai StudentId S01, ne huoc hien join, nen an xuat hien 2 lan)

        //Dùng Join() tạo kết quả gồm StudentName và CourseName bằng anonymous object như ví dụ bài học.
        var result3 = students.Join(registrations, student => student.Id, registration => registration.StudentId, (student, registration) => new { StudentName = student.Name, ObjectName = registration.ObjectName });
        foreach (var item in result3)
        {
            Console.WriteLine(item);
        }
        //Kiểm tra hai collection students và registrations gốc không bị thay đổi.
        //Tự giải thích kiểu dữ liệu của từng var mà bạn sử dụng.
    }
}