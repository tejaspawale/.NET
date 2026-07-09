namespace Account;
using Banking;

public class SavingAccount : Account
{
    public int accountHolder;

     public sealed override  void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount}. New Balance: {Balance}");
        
    }

}