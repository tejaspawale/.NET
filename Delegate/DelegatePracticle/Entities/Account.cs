namespace Banking;

public class Account
{
    public double Balance{get;set;}


    public void Withdraw(double amount)
    {
        double calculatedResult = this.Balance -amount;
    }

    public void Deposit(double amount)
    {
         double calculatedResult=this.Balance + amount;
    }
}