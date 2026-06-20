using AccountsManager.Models;

namespace AccountsManager.publisher.operations;
public interface FundTransferOperation {

    public void FundTransfer(Account acc1, Account acc2, double amount);
    
}
