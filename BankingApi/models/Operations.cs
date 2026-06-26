namespace AccountsManager.Models;

public class Operations
{
  public  double DebitAccNo {get; set;}
  public   double creditAccNo {get; set;}
  public  double amount{get; set;}

  public string Status{get;set;}
  public string StatusMessage{get;set;}

  public  DateTime Transactiontime{get; set;}

  
}