/*1. Viết method Sum(int a, int b) trả về tổng hai số.
2. Viết method IsEven(int number) trả về true nếu số chẵn.
3. Viết method CalculateAverage(double a, double b, double c).
4. Viết method GetRank(double average).
5. Viết method DisplayStudentResult().

*/

/*
using System.Data;

static int Sum(int a, int b)
{
    return a+b;
}

Console.WriteLine(Sum(3,7));

static bool IsEven(int number)
{
    return (number % 2 == 0) ? true : false;
}

Console.WriteLine(IsEven(2));

static double CalculateAverage(double csharp, double database, double web)
{
    return ((csharp + database + web) / 3);
}

Console.WriteLine(CalculateAverage(1,2,3));


static string GetRank(double average)
{
    string average_string = "";
    if(average >= 8)
    {
        average_string = "A";
    }
    else if (average >= 6.5)
    {
        average_string = "B";
    }
    else if(average >= 5)
    {
        average_string = "C";
    }
    else
    {
        average_string = "D";
    }
    return average_string;
}

Console.WriteLine(GetRank(2));
*/


/*8. Bài tập nâng cao
Tách chương trình quản lý điểm ở Ngày 2 thành các method sau:
 InputStudentName()
 InputScore(string subjectName)
 CalculateAverage(double csharp, double database, double web)
 GetRank(double average)
 DisplayResult(string fullName, double average, string rank)
 DisplayMenu() nếu bạn muốn mở rộng thành app có menu.
*/

using System.Dynamic;
using System.Runtime.CompilerServices;

static string InputStudentName()
{
    string name;
    Console.WriteLine("Enter your name: ");
    name = Console.ReadLine();
    return name;
}

static double InputScore(string subjectName)
{
    Console.WriteLine($"Enter your {subjectName} score: ");
    double Score = double.Parse(Console.ReadLine()!);
    do
    {
        if (Score < 0 || Score > 10)
        {
            Console.WriteLine($"This value is invalid. Enter your {subjectName} score: ");
            Score = double.Parse(Console.ReadLine()!);
        }
    } while (Score < 0 || Score > 10);

    return Score;
}

static double CalculateAverage(double csharp, double database, double web)
{
    return (csharp + database + web) / 3;
}

static string GetRank(double avg)
{
    string? Academic_Achievements = "";
    if (avg >= 8)
    {
        Academic_Achievements = "A";
    }
    else if (avg >= 6.5)
    {
        Academic_Achievements = "B";
    }
    else if (avg >= 5)
    {
        Academic_Achievements = "C";
    }
    else
    {
        Academic_Achievements = "D";
    }
    return Academic_Achievements;
}

static string DisplayStudentResult(string fullName, double average, string rank)
{
    return
    $"name: {fullName} \n" +
    $"average: {average} \n" +
    $"rank: {rank} \n";
}
//DisplayResult(string fullName, double average, string rank)
//DisplayMenu() nếu bạn muốn mở rộng thành app có menu.
static void DisplayMenu()
{
    string name = "";
    double csharp = 0, database = 0, web = 0;
    double avg = 0;
    string rank = "";
    while (true)
    {
        
        Console.Clear();
        Console.WriteLine("1. nhap ten: ");
        Console.WriteLine("2. nhap diem: ");
        Console.WriteLine("3. xuat diem: ");
        Console.WriteLine("4. thoat: ");

        Console.WriteLine("ban chon:");
        int yourChoice = int.Parse(Console.ReadLine());

        switch (yourChoice)
        {
            case 1:
                Console.Clear();
                name = InputStudentName();
                break;
            case 2:
                Console.Clear();
                csharp = InputScore("C#");
                database = InputScore("database");
                web = InputScore("web");
                break;
            case 3:
                Console.Clear();
                avg = CalculateAverage(csharp, database, web);
                rank = GetRank(avg);
                string result = DisplayStudentResult(name, avg, rank);
                Console.WriteLine(result);
                Console.ReadLine();
                break;
            case 4:
                return;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                Console.ReadLine();
                break;
        }
    }
}

DisplayMenu();





