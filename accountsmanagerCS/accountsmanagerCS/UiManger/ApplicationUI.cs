using AccountsManager.publisher;

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
            Console.WriteLine("5. Exit");

            int choice =
                Convert.ToInt32(Console.ReadLine());

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

        accountDepartment.deposit(accNo, amount);
    }

    public void WithdrawUI()
    {
        Console.Write("Account No : ");
        int accNo =Convert.ToInt32(Console.ReadLine());

        Console.Write("Amount : ");
        double amount =Convert.ToDouble(Console.ReadLine());

        accountDepartment.withdraw(accNo, amount);
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
        
        accountDepartment.getBalance(accNo);
    }
}