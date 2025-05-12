namespace QaBank;

public class BankAccount
{
    public BankAccount()
    {
        
    }
    public string CustomerName { get; set; } = null!;
    public int AccountNumber { get; set; }
    public decimal Balance { get; set; } = 0M;

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public bool Withdraw(decimal amount)
    {
        if (Balance < amount)
            return false;

        Balance -= amount;

        return true;
    }
}

public class CurrentAccount()
{

}
