using AccountsManager.Models;

namespace AccountsManager.UImanager;

    public class UIManager
    {
        public void DisplayMenu()
        {
             Console.WriteLine("****************************MENU***************************");
             Console.WriteLine("1.check balance ");
             Console.WriteLine("2.withdraw");
             Console.WriteLine("3.Deposite");
             Console.WriteLine("4.Transfer fund");
             Console.WriteLine("5.Create New Account");
             Console.WriteLine("6.Get Mini Statement");  
             Console.WriteLine("7.Calculate And Collect Interest");  
             Console.WriteLine("8.All Interest to All");  
             Console.WriteLine("9.Exit");
             Console.WriteLine("***********************************************************");
        }
        public int GetChoice()
        {
             Console.WriteLine("enter your choice: ");
             int choice=int.Parse(Console.ReadLine());
             return choice;
        }

        public void ExitApplication()
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("           THANK YOU FOR USING OUR APPLICATION             ");
            Console.WriteLine("***********************************************************");
        }

        public void DisplayBalance(double balance)
        {
            Console.WriteLine("\n***********************************************************");
            Console.WriteLine("Current Balance: "+balance);
            Console.WriteLine("***********************************************************\n");

        }

        public int EnterAccountNumber(string msg = "")
{
    Console.WriteLine(msg + " Enter your account number:");

    return int.Parse(Console.ReadLine());
}

        public double EnterAmount()
        {
            Console.WriteLine("enter Amount: ");
            double amount = double.Parse(Console.ReadLine());
            return amount;
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
        }


        public  Account GetAccountInfo()
        {
            Account account=new Account();
            Console.WriteLine("Enter your name");
            account.AccHolderName=Console.ReadLine();

            Console.WriteLine("Enter your email");
            account.Email = Console.ReadLine();

            Console.WriteLine("Enter your AccountNo");
            account.AccountNo =int.Parse( Console.ReadLine());

            Console.WriteLine("Enter your initial balance");
            account.balance = double.Parse(Console.ReadLine());

            account.CreatedOn=DateTime.Now;

            return account;
        }

        public void DisplayAccountSummary(Account account)
        {
            Console.WriteLine("Account Number: "+account.AccountNo);
            Console.WriteLine("Name: "+account.AccHolderName);
            Console.WriteLine("Email: "+account.Email);
            Console.WriteLine("Created On: "+account.CreatedOn);
        }

        // public void DisplayOperation(Operations operation)
        // {
        //     Console.WriteLine("|     "+operation.Status+"     |    "+operation.StatusMessage+"      |      "+operation.amount+"     |     "+operation.Transactiontime );
        //     Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

        // }

        public void DisplayOperation(Operations operation)
{
    Console.WriteLine(
        $"| {operation.Status,-6} | {operation.StatusMessage,-25} | {operation.amount,-10} | {operation.Transactiontime}"
    );

    Console.WriteLine("----------------------------------------------------------------------------------------------");
}

        // public void DisplayHeading()
        // {
        //     Console.WriteLine("------------------------------------------------------------------------------------------------------------");
        //     Console.WriteLine("| Operation Type. |           Status              |     Amount     |  Date         |     CurrentBalance      ");
        //     Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

        // }

        public void DisplayHeading()
{
    Console.WriteLine("----------------------------------------------------------------------------------------------");
    Console.WriteLine("| Status | Status Message            | Amount    | Date");
    Console.WriteLine("----------------------------------------------------------------------------------------------");
}
    }




//SOC:  