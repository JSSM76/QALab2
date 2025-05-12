namespace QaBank.Accounts;

public class CurrentAccount : BankAccount
{
    public decimal OverdraftLimit { get; set; } = 100M;

    public void Withdraw(decimal amount)
    {
        var newBalance = Withdraw(Balance + OverdraftLimit, amount);

        Balance = newBalance;
    }
}
