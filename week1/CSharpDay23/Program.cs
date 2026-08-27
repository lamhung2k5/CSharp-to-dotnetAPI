public class Program
{
    public static void Main(string[] args)
    {
        //Dùng try-catch để xử lý exception.
        try
        {
            
            //Gọi DisplayValue() với int, string, decimal và một object tự tạo.
            int value1 = 3;
            string value2 = "hello";
            decimal value3 = 100m;
            Employee value4 = new Employee("NV01", "Hung", 1_000_000m);

            //thử int
            GenericHelper.DisplayValue<int>(value1);

            //thử string
            GenericHelper.DisplayValue<string>(value2);

            //thử decimal (đổi cú pháp)
            GenericHelper.DisplayValue(value3);

            //Thử với Employee
            GenericHelper.DisplayValue(value4);

            //Tạo List<int> và dùng GetFirstItem(), GetLastItem().
            Console.WriteLine("========List<int>=======");
            List<int> nums = new List<int> { 3, 4, 5, 6, 8 };
            Console.WriteLine($"First item: {GenericHelper.GetFirstItem(nums)}");
            Console.WriteLine($"Last item: {GenericHelper.GetLastItem(nums)}");

            //Tạo List<string> và dùng lại hai method trên.
            Console.WriteLine("========List<string>=======");
            List<string> strs = new List<string> { "a", "b", "c", "d", "e", "f" };
            Console.WriteLine($"First item: {GenericHelper.GetFirstItem(strs)}");
            Console.WriteLine($"Last item: {GenericHelper.GetLastItem(strs)}");

            //C# - Collections & Generics | Phần 8.6
            //Dùng SwapValues() với hai số nguyên.
            Console.WriteLine("========Swap (int)=======");
            int a = 3; 
            int b = 4;
            Console.WriteLine($"before: a: {a}, b: {b}");

            GenericHelper.SwapValues(ref a, ref b);

            Console.WriteLine($"after: a: {a}, b: {b}");

            //Dùng SwapValues() với hai chuỗi.
            Console.WriteLine("========Swap (string)=======");
            string str1 = "Hello ";
            string str2 = "World ";
            Console.WriteLine($"before: str1: {str1}, str2: {str2}");

            GenericHelper.SwapValues(ref str1, ref str2);

            Console.WriteLine($"after: str1: {str1}, str2: {str2}");
            //Dùng AreValuesEqual() với hai số bằng nhau và hai chuỗi khác nhau.
            
            int num1 = 1, num2 = 1;
            string s1 = "a", s2 = "b";

            Console.WriteLine("========AreValuesEqual (int)=======");
            Console.WriteLine(GenericHelper.AreValuesEqual(num1, num2));

            Console.WriteLine("========AreValuesEqual (string)=======");
            Console.WriteLine(GenericHelper.AreValuesEqual(s1, s2));


            //Gọi DisplayKeyValue() với string-string, string-decimal và int-object.
            Console.WriteLine("========DisplayKeyValue (string-string)=======");
            GenericHelper.DisplayKeyValue("NV01", "Hung");

            Console.WriteLine("========DisplayKeyValue (string-decimal)=======");
            GenericHelper.DisplayKeyValue("NV01", 3_000_000m);

            Console.WriteLine("========DisplayKeyValue (int - object)=======");
            GenericHelper.DisplayKeyValue("NV01", value4);

            //Thử truyền một danh sách rỗng vào GetFirstItem(). 
            Console.WriteLine("========truyền ds rỗng vào GetFirstItem=======");
            List<int> lists = new List<int>();
            GenericHelper.GetFirstItem(lists);
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
          
        
    }
}