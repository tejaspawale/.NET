using AccountsManager.Models;

namespace AccountsManager.publisher.operations;
public interface FundTransferOperation {
    public void FundTransfer(double fromAccout,double ToAccount,double amount);
    
}
