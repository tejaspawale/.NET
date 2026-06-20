using AccountsManager.Listners;
using AccountsManager.publisher;
using AccountsManager.services;
using AccountsManager.repository;
using AccountsManager.Models;
using AccountsManager.Ui;

namespace AccountsManager;

class Program
{
    public static void Main(string[] args)
    {
        AccountRepository accountRepository =new AccountRepository();

        List<Account> accounts = accountRepository.GetAllAccounts();

        NotificationService notificationService =new SmsService();

        AccountDepartment accountDepartment =new AccountDepartment(accounts, notificationService);

        AccountsDepartment listener = new AccountsDepartment();

        accountDepartment.addListener(listener);

        UiManager uiManager =new UiManager(accountDepartment);

        uiManager.ShowMenu();
    }
}