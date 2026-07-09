using ActionListener.publishers;
using ActionListener.Services;
using ActionListener.publishers.operation;
namespace  ActionListener.publishers;
public class TransferFund : TransferManager
{
    public double amount{get; set;}
        NotificationService smsService=new SMSService();
            
    public void fundTransfer(Account acc1,Account acc2,double amount)
    {
        Account account1 = new Account(52000,smsService);
        Account account2 = new Account(3600,smsService);

        account1.withdraw(2200);
        account2.deposite(2200);

        account1 debite 2200 at 4.pm to
     account2 credit 22200
       

        id 1 tejas 5200   last 46544
        id 2 yash 300   last
      

        id 1 tejas 5200   last
        id 2 yash 300   last




    }
}