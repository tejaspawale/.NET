namespace AccountsManager.publisher.operations;
public interface IWithdrawOperation {

    bool Withdraw(double AccountNo, double amount);
    
}
