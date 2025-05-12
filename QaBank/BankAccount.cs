namespace QaBank;

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

    internal static bool Withdraw(decimal balance, decimal amount)
    {
        if (balance < amount)
            return false;

        balance -= amount;

        return true;
    }
}

public class CurrentAccount : BankAccount
{
    public decimal OverdraftLimit { get; set; } = 100M;

    public bool Withdraw(decimal amount) => Withdraw(Balance + OverdraftLimit, amount);
}

public class SavingsAccount : BankAccount
{
    public decimal InterestRate { get; set; } = 0M;

    public void AddInterest()
    {
        if (Balance <= 0)
            return;

        var interest = Balance * InterestRate / 100;

        Balance += interest;

        return;
    }
}

public static class Variables
{
    public static int AccountNumber = 100_000;
}