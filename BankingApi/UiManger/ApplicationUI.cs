using AccountsManager.publisher;
using AccountsManager.repository;
using AccountsManager.Models;

namespace AccountsManager.Ui;

public class UiManager
{
    private AccountDepartment accountDepartment;

    public UiManager(AccountDepartment accountDepartment)
    {
        this.accountDepartment = accountDepartment;
    }

    public void ShowMenu()
    {
        while(true)
        {
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Fund Transfer");
            Console.WriteLine("4. Check Balance");
            Console.WriteLine("5. MiniStatement");
            Console.WriteLine("6. Interest Rate");
            Console.WriteLine("7. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    DepositUI();
                    break;

                case 2:
                    WithdrawUI();
                    break;

                case 3:
                    FundTransferUI();
                    break;

                case 4:
                    BalanceUI();
                    break;

                case 5:
                        MiniStatement();
                        break;
                case 6:
                        InterestRate();
                        break;

                case 7:
                    return;

            }
        }
    }

    public void DepositUI()
    {
        Console.Write("Account No : ");
        int accNo =Convert.ToInt32(Console.ReadLine());

        Console.Write("Amount : ");
        double amount = Convert.ToDouble(Console.ReadLine());

        accountDepartment.Deposit(accNo, amount);
    }

    public void WithdrawUI()
    {
        Console.Write("Account No : ");
        int accNo =Convert.ToInt32(Console.ReadLine());

        Console.Write("Amount : ");
        double amount =Convert.ToDouble(Console.ReadLine());

        accountDepartment.Withdraw(accNo, amount);
    }

    public void FundTransferUI()
    {
        Console.Write("From Account : ");
        int from =Convert.ToInt32(Console.ReadLine());

        Console.Write("To Account : ");
        int to =Convert.ToInt32(Console.ReadLine());

        Console.Write("Amount : ");
        double amount =Convert.ToDouble(Console.ReadLine());

        accountDepartment.FundTransfer(from,to,amount);
    }

    public void BalanceUI()
    {
        Console.Write("Account No : ");
        int accNo = Convert.ToInt32(Console.ReadLine());
        
        accountDepartment.GetBalance(accNo);
        
    }

    public void InterestRate()
    {
        Console.Write("Account No : ");
        int accNo = Convert.ToInt32(Console.ReadLine());
        
        accountDepartment.CalculateInterest(accNo);
    }
    

 public void MiniStatement()
{
    Console.Write("Account No : ");
    int accNo = Convert.ToInt32(Console.ReadLine());

    List<Operations> statements = accountDepartment.GetMiniStatement(accNo);


    Console.WriteLine("\nMini Statement");

    foreach (Operations operation in statements)
    {
        Console.WriteLine( $"Date : {operation.Transactiontime}");

        Console.WriteLine( $"Debit : {operation.DebitAccNo}");

        Console.WriteLine($"Credit : {operation.creditAccNo}");

        Console.WriteLine( $"Amount : {operation.amount}");

        Console.WriteLine("-------------------");
    }
}


}
