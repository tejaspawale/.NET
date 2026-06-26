using AccountsManager.services;
using AccountsManager.Listners;
using AccountsManager.publisher.operations;
using AccountsManager.Models;
using AccountsManager.repository;

namespace AccountsManager.publisher;

public class AccountDepartment : IFundTransferOperation, IDepositOperation, IWithdrawOperation, IMiniStatementOperations, ICalculateInterestOperation
{
   // List<Account> accounts { get; set; }
    NotificationService service;

    
    public List<AccountListener> listeners = new List<AccountListener>();

    public AccountDepartment(NotificationService notificationService)
    {
        this.service = notificationService;
    }


    public double GetBalance(int accountNo)
{
    AccountRepository accountRepository = new AccountRepository();
    List<Account> accounts = accountRepository.GetAllAccounts();

    Account account = accounts.FirstOrDefault(a => a.AccountNo == accountNo);

    if (account != null)
    {
        account.lastTransaction = DateTime.Now;

        accountRepository.SaveAllAccounts(accounts);

        return account.balance;
    }

    return 0;
}

    public bool Deposit(double AccountNo, double amount)
    {   
        bool status = false;
        AccountRepository accountRepository = new AccountRepository();

        List<Account> accounts = accountRepository.GetAllAccounts();
        Account account = accounts.FirstOrDefault(a => a.AccountNo == AccountNo);

            if (account.AccountNo == AccountNo)
            {
                account.balance += amount;
                account.lastTransaction = DateTime.Now;
                CheckBalance(account);
                accountRepository.SaveAllAccounts(accounts);
            }
        return status;
    }
    public bool Withdraw(double AccountNo, double amount)
    {   bool status = false;
        AccountRepository accountRepository = new AccountRepository();
        List<Account> accounts = accountRepository.GetAllAccounts();
        Account account = accounts.FirstOrDefault(a => a.AccountNo ==AccountNo );
            if (account.AccountNo == AccountNo)
            {
                account.balance -= amount;
                account.lastTransaction = DateTime.Now;
                accountRepository.SaveAllAccounts(accounts);

            }
            return status;
    }



    public void CheckBalance(Account a)
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



public bool FundTransfer(double fromAccount, double toAccount, double amount)
{
    AccountRepository accountRepository = new AccountRepository();
    OperationsRepository operationsRepository = new OperationsRepository();

    List<Account> accounts = accountRepository.GetAllAccounts();

    Account? sender = accounts.FirstOrDefault(a => a.AccountNo == fromAccount);
    Account? receiver = accounts.FirstOrDefault(a => a.AccountNo == toAccount);

    if (sender == null || receiver == null)
    {
        return false;
    }

    if (sender.balance < amount)
    {
        return false;
    }

    sender.balance -= amount;
    sender.lastTransaction = DateTime.Now;

    receiver.balance += amount;
    receiver.lastTransaction = DateTime.Now;

    accountRepository.SaveAllAccounts(accounts);

    List<Operations> operations = operationsRepository.GetAllOperations();

    Operations operation = new Operations()
    {
        DebitAccNo = fromAccount,
        creditAccNo = toAccount,
        amount = amount,
        Transactiontime = DateTime.Now,
        Status = "D",
        StatusMessage = $"Fund Transfer To {toAccount}"
    };

    operations.Add(operation);

    operationsRepository.SaveAllOperations(operations);

    return true;
}
    public int CompareTransactions(Operations op1, Operations op2)
    {
        int CompareTras = op2.Transactiontime.CompareTo(op1.Transactiontime);
        return CompareTras;
    }

    public List<Operations> GetMiniStatement(int accountNumber)
{
    OperationsRepository operationsRepository = new OperationsRepository();

    List<Operations> operations = operationsRepository.GetAllOperations();

    return operations
        .Where(op => op.DebitAccNo == accountNumber || 
        op.creditAccNo == accountNumber)
        .OrderByDescending(op => op.Transactiontime)
        .Take(5)
        .ToList();
}


    public double CalculateInterest(double accountNo)
{
    AccountRepository accountRepository = new AccountRepository();

    List<Account> accounts = accountRepository.GetAllAccounts();

    Account? account = accounts.FirstOrDefault(a => a.AccountNo == accountNo);

    if (account != null)
    {
        double interest = account.balance * account.InterestRate / 100;

        account.balance += interest;
        account.lastTransaction = DateTime.Now;

        accountRepository.SaveAllAccounts(accounts);

        return interest;
    }

    return 0;
}

public bool CreateAccount(Account account)
        {
            bool status=false;
            AccountRepository accountRepository = new AccountRepository();
            List<Account> accounts = accountRepository.GetAllAccounts();
            accounts.Add(account);
            accountRepository.SaveAllAccounts(accounts);
            status =true;
            return status;
        }


    public Account GetAccount(int accountId)
        {   
            AccountRepository accountRepository = new AccountRepository();
            List<Account> accounts = accountRepository.GetAllAccounts();
            Account account = accounts.FirstOrDefault(a => a.AccountNo == accountId);
            if (account != null)
            {
                return account;
            }

            return null;
        }


    public void AddListener(AccountListener listener)
    {
        listeners.Add(listener);

    }

}