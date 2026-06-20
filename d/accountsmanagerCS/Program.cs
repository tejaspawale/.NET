using AccountsManager.Listners;
using AccountsManager.publisher;
using AccountsManager.services;
using AccountsManager.publisher.operations;
using AccountsManager.repository;
using AccountsManager.Models;

namespace AccountsManager;

class Program 
{
    public static void Main(string[] args)
    {
        AccountRepository accountRepository= new AccountRepository();
        NotificationService smsService = new SmsService();
        // // AccountDepartment account1 = new AccountDepartment(5000, smsService);
       
        // account1.addListener(new AccountsDepartment());

        // account1.withdraw(4500);
        // account1.deposit(300000);
         List<Account>accounts=accountRepository.GetAllAccounts();

        AccountDepartment accountDepartment=new AccountDepartment(accounts,smsService);
    //    accountDepartment.getBalance(1001);
    //    accountDepartment.deposit(1001,5000);
    //    accountDepartment.withdraw(1,100);
        accountDepartment.FundTransfer(1002,1001,1000);
       
        
    }
}


