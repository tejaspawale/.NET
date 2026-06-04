namespace Banking;
// Parent class
public class Account
{
    public static  int count;

    private decimal balance ;   //encapsulation
    public decimal Balance {  //expose using public property

        get
        {
            return this.balance;    
        }
        set
        {
            if(value >=5000)
            {
                this.balance=value;
            }
            else
            {
                throw new ArgumentException("Balance should be greater than 5000");
            }
        }
    }

    public Account()
    {
        this.balance=0;
        count++;
    }
    public Account(decimal amount)
    {
        this.balance=amount;
        count++;
    }
    public virtual void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount}. New Balance: {Balance}");
        
    }



    public decimal Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount}. New Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds!");
        }
        return Balance;
    }
}

// Child class
class SavingAccount : Account
{
    public static  new  int  count; //shadowing  variable
    public decimal InterestRate { get; set; } = 0.05m;
    public SavingAccount()
    {
        count++;
    }
    public SavingAccount(decimal amount, decimal intRate)
    {
        this.Balance=amount;
        this.InterestRate=intRate;
        count++;
    }
    public void ApplyInterest()
    {
        Balance += Balance * InterestRate;
        Console.WriteLine($"Interest applied. New Balance: {Balance}");
    }
}