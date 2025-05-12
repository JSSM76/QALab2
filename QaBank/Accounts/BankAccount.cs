namespace QaBank.Accounts;

public abstract class BankAccount
{
    public BankAccount()
    {
        AccountNumber = Variables.AccountNumber++;
    }
    public required string CustomerName { get; set; } = null!;
    public int AccountNumber { get; set; }
    public decimal Balance { get; set; } = 0M;

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    internal static decimal Withdraw(decimal balance, decimal amount)
    {
        if (balance < amount)
            return balance;

        balance -= amount;

        return balance;
    }
}
