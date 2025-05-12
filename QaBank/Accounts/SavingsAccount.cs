namespace QaBank.Accounts;

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
