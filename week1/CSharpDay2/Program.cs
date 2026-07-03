/*
1. Nhập tuổi, kiểm tra người dùng đủ 18 tuổi hay chưa.
2. Nhập một số nguyên, kiểm tra số chẵn hay số lẻ.
3. Nhập điểm trung bình, xếp loại học lực. 
4. In ra các số từ 1 đến 100 bằng for.
5. Tính tổng các số từ 1 đến n.
6. Tạo menu đơn giản với switch: 1 - thêm, 2 - sửa, 3 - xóa, 0 - thoát.

Viết chương trình quản lý điểm một sinh viên. Yêu cầu:
Nhập họ tên.
Nhập điểm C#, Cơ sở dữ liệu, Web.
Kiểm tra điểm có nằm trong khoảng 0 đến 10 hay không.
Tính điểm trung bình.
Xếp loại học lực.
In kết quả theo format rõ ràng.
*/

/*Console.WriteLine("Enter your age: ");
double age = double.Parse(Console.ReadLine()!);

if(age < 18)
{
    Console.WriteLine("the value you just entered is invalid");
}
else
{
    Console.WriteLine("the value you just entered is valid");
}
*/

/*
Console.WriteLine("Enter any number: ");
int num = int.Parse(Console.ReadLine()!);

if(num % 2 == 0)
{
    Console.WriteLine("the value you just entered is even number");
}
else
{
    Console.WriteLine("the value you just entered is odd number");
}
*/

/*
Console.WriteLine("Enter the average score: ");
double avg = double.Parse(Console.ReadLine()!);

if(avg >= 8)
{
    Console.WriteLine("A");
}
else if (avg >= 6.5)
{
    Console.WriteLine("B");
}
else if(avg >= 5)
{
    Console.WriteLine("C");
}
else{
    Console.WriteLine("D");
}
*/

/*
for(int i = 0; i <= 100; i++)
{
    Console.WriteLine($"{i}");
}
*/

/*
int sum = 0;
for(int i = 0; i <= 100; i++)
{
    sum += i;
}
Console.WriteLine(sum);
*/

/*
Console.WriteLine("============================");
Console.WriteLine("1. them");
Console.WriteLine("2. sua");
Console.WriteLine("3. xoa");
Console.WriteLine("4. thoat");
Console.WriteLine("============================");

Console.WriteLine("Enter your choosing: ");
int choose = int.Parse(Console.ReadLine()!);

switch (choose)
{
    case 1:
        Console.WriteLine("you choose: them");
        break;
    case 2:
        Console.WriteLine("you choose: sua");
        break;
    case 3:
        Console.WriteLine("you choose: xoa");
        break;
    default:
        Console.WriteLine("you choose: thoat");
        break;
}
*/

/*
Viết chương trình quản lý điểm một sinh viên. Yêu cầu:
Nhập họ tên.
Nhập điểm C#, Cơ sở dữ liệu, Web.
Kiểm tra điểm có nằm trong khoảng 0 đến 10 hay không.
Tính điểm trung bình.
Xếp loại học lực.
In kết quả theo format rõ ràng.
*/
Console.WriteLine("Enter your name: ");
String? name = Console.ReadLine();

//Enter C# score
Console.WriteLine("Enter your C# score: ");
double? CSharpScore = double.Parse(Console.ReadLine()!);
do
{
    if(CSharpScore < 0 || CSharpScore > 10)
    {
        Console.WriteLine("This value is invalid. Enter your C# score: ");
        CSharpScore = double.Parse(Console.ReadLine()!);
    }
}while(CSharpScore < 0 || CSharpScore > 10);

//Enter DB score
Console.WriteLine("Enter your DB score: ");
double? DBScore = double.Parse(Console.ReadLine()!);
do
{
    if(DBScore < 0 || DBScore > 10)
    {
        Console.WriteLine("This value is invalid. Enter your C# score: ");
        DBScore = double.Parse(Console.ReadLine()!);
    }
}while(DBScore < 0 || DBScore > 10);

//Enter Web score
Console.WriteLine("Enter your web score: ");
double? WebScore = double.Parse(Console.ReadLine()!);
do
{
    if(WebScore < 0 || WebScore > 10)
    {
        Console.WriteLine("This value is invalid. Enter your C# score: ");
        WebScore = double.Parse(Console.ReadLine()!);
    }
}while(WebScore < 0 || WebScore > 10);

//caculate the average score
double? avg = (CSharpScore + DBScore + WebScore) / 3;
string? Academic_Achievements = "";
if(avg >= 8)
{
    Academic_Achievements = "A";
}
else if (avg >= 6.5)
{
    Academic_Achievements = "B";
}
else if(avg >= 5)
{
    Academic_Achievements = "C";
}
else
{
    Academic_Achievements = "D";
}

//print the result

Console.WriteLine("============================");
Console.WriteLine($"name: {name}");
Console.WriteLine($"C# score: {CSharpScore}");
Console.WriteLine($"DB score: {DBScore}");
Console.WriteLine($"Web score: {WebScore}");
Console.WriteLine($"average score: {avg}");
Console.WriteLine($"academic achievements: {Academic_Achievements}");
Console.WriteLine("============================");


