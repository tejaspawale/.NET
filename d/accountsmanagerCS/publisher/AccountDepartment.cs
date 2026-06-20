using AccountsManager.services;
using AccountsManager.Listners;
using AccountsManager.publisher.operations;
using AccountsManager.Models;
using AccountsManager.repository;
using System.Transactions;
using System.Diagnostics.CodeAnalysis;

namespace AccountsManager.publisher;

public class AccountDepartment
{
    List<Account> accounts { get; set; }
    NotificationService service;

    public AccountDepartment(List<Account> accounts, NotificationService notificationService)
    {

        
        this.service = notificationService;
        this.accounts = accounts;
    }

    AccountRepository accountRepository = new AccountRepository();
    public List<AccountListener> listeners = new List<AccountListener>();


    public double getBalance(int AccountNo)
    {
        foreach (Account a in accounts)
        {
            if (a.AccountNo == AccountNo)
            {
                a.lastTransaction = DateTime.Now;
                Console.WriteLine($"Balance in account with id {a.AccHolderName}is {a.balance}");
                accountRepository.SaveAllAccounts(accounts);
                return a.balance;
            }

        }
        return 0;
    }

    public void deposit(int AccountNo, double amount)
    {
        foreach (Account a in accounts)
        {
            if (a.AccountNo == AccountNo)
            {

                a.balance += amount;
                a.lastTransaction = DateTime.Now;
                Console.WriteLine($"Balance in account with id {a.AccountNo} after deposite is {a.balance}");
                checkBalance(a);
                accountRepository.SaveAllAccounts(accounts);
            }
        }
    }
    public void withdraw(int AccountNo, double amount)
    {
        foreach (Account a in accounts)
        {
            if (a.AccountNo == AccountNo)
            {

                a.balance -= amount;
                a.lastTransaction = DateTime.Now;
                Console.WriteLine($"Balance in account with id {a.AccountNo} after Withdraw is {a.balance}");
                accountRepository.SaveAllAccounts(accounts);
                checkBalance(a);
            }
        }
    }

    public void FundTransfer(int DebitAccNo, int creditAccNo, double transferAmount)
    {
        foreach (Account a in accounts)
        {
            if (a.AccountNo == DebitAccNo)
            {
                withdraw(a.AccountNo, transferAmount);
                a.lastTransaction = DateTime.Now;
                accountRepository.SaveAllAccounts(accounts);
                Console.WriteLine($"Balance in account with id {a.AccountNo} after Withdraw is {a.balance}");
            }
        }
        foreach (Account b in accounts)
        {
            if (b.AccountNo == creditAccNo)
            {
                deposit(b.AccountNo, transferAmount);
                b.lastTransaction = DateTime.Now;
                accountRepository.SaveAllAccounts(accounts);
                Console.WriteLine($"Balance in account with id {b.AccountNo} after Withdraw is {b.balance}");
            }
        }
    }


    public void checkBalance(Account a)
    {
        if (a.balance < 1000)
        {
            foreach (AccountListener l in listeners)
            {
                l.onOverBalance(a.balance);
                service.send("Amount Less Than Minimum Balance Policy");
            }
        }

        if (a.balance > 250000)
        {
            foreach (AccountListener l in listeners)
            {
                l.onOverBalance(a.balance);
                service.send("Amount is greater than  Taxable income policy");
            }
        }
    }

    public void addListener(AccountListener listener)
    {
        listeners.Add(listener);

    }
}