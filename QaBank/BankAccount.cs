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

    internal static decimal Withdraw(decimal balance, decimal amount)
    {
        if (balance < amount)
            return balance;

        balance -= amount;

        return balance;
    }
}

public class CurrentAccount : BankAccount
{
    public decimal OverdraftLimit { get; set; } = 100M;

    public void Withdraw(decimal amount)
    {
        var newBalance = Withdraw(Balance + OverdraftLimit, amount);

        Balance = newBalance;
    }
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