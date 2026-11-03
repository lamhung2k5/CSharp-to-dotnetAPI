public class BankService
{
    public void ProcessWithdrawal(BankAccount account, decimal amount)
    {
        if(account == null)
        {
            throw new ArgumentNullException(nameof(account), "Bank Account cannot be null.");
        }

        try
        {
            account.Withdraw(amount);
        }
        catch(InvalidOperationException)
        {
            Console.WriteLine("Withdrawal processing failed");
            throw;
        }    
    }
}