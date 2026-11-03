public class Program
{
    public static int ConvertAge(string input)
    {
        try
        {
            return int.Parse(input);
        }   
        catch(FormatException ex)
        {
            throw new InvalidOperationException("Cannot convert age.", ex);
        }
    }

    public static void Main(string[] args)
    {
        try
        {
            BankAccount account = new BankAccount("1233",1000);

            account.Withdraw(200);
            account.Withdraw(-50);
        }
        catch(ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Argument Exception: {ex.Message}");
        }

        try
        {
            BankAccount account = new BankAccount("1233",1000);

            account.Withdraw(200);
            account.Withdraw(1000);
        }
        catch(InvalidOperationException ex)
        {
            Console.WriteLine($"Invalid Operation: {ex.Message}");
        }

        try
        {
            BankAccount account = new BankAccount("1233",1000);
            BankService service = new BankService();

            service.ProcessWithdrawal(account, 200);
            service.ProcessWithdrawal(account, 1000);
        }
        catch(InvalidOperationException ex)
        {
            Console.WriteLine($"Invalid Operation: {ex.Message}");
        }

        try
        {
            int age = ConvertAge("abc");
            Console.WriteLine($"Converted Age: {age}");
        }
        catch(InvalidOperationException ex)
        {
            Console.WriteLine($"Conversion Error: {ex.Message}");
            //kiểm tra nguyên nhân gốc của lỗi
            Console.WriteLine($"Original Error: {ex.InnerException?.Message}");
        }
    }
}