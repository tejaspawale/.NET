using AccountsManager.services;
using AccountsManager.Listners;
using AccountsManager.publisher.operations;
using AccountsManager.Models;
using AccountsManager.repository;

namespace AccountsManager.publisher;

public class AccountDepartment : IFundTransferOperation,IDepositOperation,IWithdrawOperation,IMiniStatementOperations,ICalculateInterestOperation
{
    List<Account> accounts { get; set; }
    NotificationService service;

    public AccountDepartment(List<Account> accounts, NotificationService notificationService)
    {
        this.service = notificationService;
        this.accounts = accounts;
    }
    AccountRepository accountRepository = new AccountRepository();
    OperationsRepository operationsRepository = new OperationsRepository();
    public List<AccountListener> listeners = new List<AccountListener>();


    public double GetBalance(int AccountNo)
    {
        foreach (Account account in accounts)
        {
            if (account.AccountNo == AccountNo)
            {
                account.lastTransaction = DateTime.Now;
                Console.WriteLine($"Balance in account with id {account.AccHolderName}is {account.balance}");
                accountRepository.SaveAllAccounts(accounts);

                return account.balance;
            }

        }
        return 0;
    }

    public void Deposit(double AccountNo, double amount)
{
    foreach (Account account in accounts)
    {
        if (account.AccountNo == AccountNo)
        {
            account.balance += amount;
            account.lastTransaction = DateTime.Now;

            Console.WriteLine($"Balance in account with id {account.AccountNo} after deposit is {account.balance}");

            CheckBalance(account);

            accountRepository.SaveAllAccounts(accounts);

            break;
        }
    }
}
    public void Withdraw(double AccountNo, double amount)
{
    foreach (Account account in accounts)
    {
        if (account.AccountNo == AccountNo)
        {
            account.balance -= amount;
            account.lastTransaction = DateTime.Now;

            Console.WriteLine( $"Balance in account with id {account.AccountNo} after withdraw is {account.balance}");

            accountRepository.SaveAllAccounts(accounts);

            break;
        }
    }
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




public void FundTransfer(double fromAccount,double toAccount,double amount)
{
    Account? sender = null;
    Account? receiver = null;

    foreach (Account a in accounts)
    {
        if (a.AccountNo == fromAccount)
        sender = a;

        if (a.AccountNo == toAccount)
            receiver = a;
    }

    if (sender == null || receiver == null)
    {
        Console.WriteLine("Account Not Found");
        return;
    }

    if (sender.balance < amount)
    {
        Console.WriteLine("Insufficient Balance");
        return;
    }

    Withdraw(fromAccount, amount);

    Deposit(toAccount, amount);

    Operations operation = new Operations()
    {
        DebitAccNo = fromAccount,
        creditAccNo = toAccount,
        amount = amount,
        Transactiontime = DateTime.Now
    };

    List<Operations> operations = operationsRepository.GetAllOperations();

    operations.Add(operation);

    operationsRepository.SaveAllOperations(operations);

    Console.WriteLine("Transfer Successful");
}

public int CompareTransactions(Operations op1,Operations op2)
{     int CompareTras =op2.Transactiontime.CompareTo(op1.Transactiontime);
    return CompareTras;
}

public  List<Operations> GetMiniStatement(int accountNumber)
{
    List<Operations> statements = new List<Operations>();
    List<Operations> operations = operationsRepository.GetAllOperations();

    foreach (Operations Operation in operations)
    {
        if (Operation.DebitAccNo == accountNumber ||
            Operation.creditAccNo == accountNumber)
        {
            statements.Add(Operation);
        }
    }
    statements.Sort(CompareTransactions);

    if (statements.Count > 5)
    {
        statements = statements.GetRange(0, 5);
    }

    return statements;
}


public void CalculateInterest(double accountNo)
{
    foreach(Account a in accounts)
    {
        if(a.AccountNo == accountNo)
        {
            double interest = a.balance * a.InterestRate / 100;

            a.balance += interest; 

            a.lastTransaction = DateTime.Now;

            Console.WriteLine($"Interest Credited : {interest}");
            Console.WriteLine($"Current Balance : {a.balance}");

            accountRepository.SaveAllAccounts(accounts);
            return;
        }
    }

    Console.WriteLine("Account Not Found");
}
    

    public void AddListener(AccountListener listener)
    {
        listeners.Add(listener);

    }

}