namespace AccountsManager.Models;

public class Account
{
    
    public string AccHolderName {get; set;}
    public int AccountNo {get; set;}
    public double balance {get; set;}
    public DateTime lastTransaction {get; set;}
    public double InterestRate{get; set;} = 4;

   
   public Account()
    {
        
    }

 }