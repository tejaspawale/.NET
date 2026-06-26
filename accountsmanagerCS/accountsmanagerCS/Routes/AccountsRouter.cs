
using AccountsManager.Ui;
using AccountsManager.UImanager;
using AccountsManager.publisher;
using AccountsManager.services;
using AccountsManager.Models;
using AccountsManager.repository;
namespace AccountsManager.Routes;

public class AccountsRouter
{
    int choice;
    UIManager ui = new UIManager();
    OperationsRepository operationsRepository = new OperationsRepository();


    NotificationService smsService = new SmsService();
    public void BankingOperations()
    {
        List<Operations> operations = operationsRepository.GetAllOperations();
        AccountDepartment accountDepartment = new AccountDepartment(smsService);
        do
        {
            ui.DisplayMenu();
            choice = ui.GetChoice();

            switch (choice)
            {
                case 1:
                    {
                        int accno = ui.EnterAccountNumber();
                        double balance = accountDepartment.GetBalance(accno);
                        Account account = accountDepartment.GetAccount(accno);
                        if (balance > 0)
                        {
                            ui.DisplayAccountSummary(account);
                            ui.DisplayBalance(balance);
                        }
                        else
                        {
                            ui.DisplayMessage("Account not exists");
                        }
                    }
                    break;
                case 2:
                    {
                        int accno = ui.EnterAccountNumber();
                        double amount = ui.EnterAmount();
                        bool status = accountDepartment.Withdraw(accno, amount);
                        double balance = accountDepartment.GetBalance(accno);
                        if (status)
                        {
                            ui.DisplayMessage("withdraw amount succesfully");
                        }
                        else
                        {
                            ui.DisplayMessage("does not withdraw amount first check your balance");
                        }

                        break;
                    }
                case 3:
                    {
                        int accno = ui.EnterAccountNumber();
                        double amount = ui.EnterAmount();
                        bool status = accountDepartment.Deposit(accno, amount);
                        double balance = accountDepartment.GetBalance(accno);
                        if (status)
                        {
                            ui.DisplayMessage("deposite amount successfully");
                        }
                        else
                        {
                            ui.DisplayMessage("does not Deposite amount first check your balance");
                        }
                        break;
                    }
                case 4:
                    {
                        int fromAccount = ui.EnterAccountNumber("From : ");
                        int toAccount = ui.EnterAccountNumber("To : ");
                        double amount = ui.EnterAmount();

                        bool status = accountDepartment.FundTransfer(fromAccount, toAccount, amount);

                        if (status)
                        {
                            ui.DisplayMessage("Fund Transfer Successful");
                        }
                        else
                        {
                            ui.DisplayMessage("Fund Transfer Failed");
                        }

                        break;
                    }

                case 5:
                    {
                        Account account = ui.GetAccountInfo();
                        bool status = accountDepartment.CreateAccount(account);
                        if (status)
                        {
                            ui.DisplayMessage("account created successfully");
                        }
                        else
                        {
                            ui.DisplayMessage("account not created");
                        }
                    }
                    break;
                case 6:
                    {
                        int accno = ui.EnterAccountNumber();
                        List<Operations> miniStatement = accountDepartment.GetMiniStatement(accno);
                        ui.DisplayHeading();
                        foreach (Operations op in miniStatement)
                        {

                            ui.DisplayOperation(op);

                        }
                        break;
                    }
                case 7:
                    {
                        int accno = ui.EnterAccountNumber();
                        double totalInterest = accountDepartment.CalculateInterest(accno);
                        Console.WriteLine("" + totalInterest);
                        bool status = accountDepartment.Deposit(accno, totalInterest);

                        double balance = accountDepartment.GetBalance(accno);
                        if (status)
                        {
                            ui.DisplayMessage("Interest amount deposit successfully");
                        }
                        else
                        {
                            ui.DisplayMessage("Interest amount not deposit");
                        }
                        break;
                    }

                    case 8:
                    ui.ExitApplication();
                    break;









            }



        } while (choice != 9);
    }
}