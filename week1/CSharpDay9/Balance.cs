public class BankAccount
{
    public decimal Balance { get; private set; }

    public BankAccount(decimal balance)
    {
        if(Balance < 0)
        {
            throw new ArgumentException("So du khong duoc am", nameof(balance));
        }
        Balance = balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("so tien gia dich khong duoc am", nameof(amount));
        }
        Balance += amount;
    }
}