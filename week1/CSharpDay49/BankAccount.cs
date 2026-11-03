public class BankAccount
{
    public string AccountNumber {get; }
    public decimal Balance {get; private set; }

    public BankAccount(string accountNumber, decimal balance)
    {
        if(string.IsNullOrWhiteSpace(accountNumber))
        {
            throw new ArgumentException("Account number cannot be null or whitespace", nameof(accountNumber));
        }

        if(balance < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(balance), "Balance cannot be negative.");  
        }

        AccountNumber = accountNumber.Trim();
        Balance = balance;
    }

    public void Withdraw(decimal amount)
    {
        if(amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount),"Withdrawal amount must be greater than zero.");
        }

        if(amount > Balance)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }

        Balance -= amount;

        Console.WriteLine($"Withdrawal of {amount} successful. New balance: {Balance}");
    }
}